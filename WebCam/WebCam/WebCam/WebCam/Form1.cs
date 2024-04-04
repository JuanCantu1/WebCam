using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCam
{
    public partial class Form1 : Form
    {
        private VideoCaptureDevice videoCapture;
        private FilterInfoCollection filterInfo;
        private int captureCount = 1;
        private Timer autoCaptureTimer;
        private FileSystemWatcher watcher;
        private string outputFolderPath = @"C:\Output";
        private string outputImagePath = @"C:\Output\Output.jpg";
        private string InputFolderPath = @"C:\Input";
        private string InputImagePath = @"C:\Input\Input.jpg";
        private Process pythonProcess; // Declare a variable to hold the Python process

        public Form1()
        {
            InitializeComponent();

            // Set the minimum, maximum, and default values for the NumericUpDown control
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 10;
            numericUpDown1.Value = 5;

            // Ensure input and output folders exist
            EnsureFoldersExist();

            // Initialize and configure the timer
            autoCaptureTimer = new Timer();
            int interval = (int)numericUpDown1.Value * 1000;
            if (interval > 0)
            {
                autoCaptureTimer.Interval = interval;
            }
            else
            {
                autoCaptureTimer.Interval = 1000; // 1 second
            }
            autoCaptureTimer.Tick += AutoCaptureTimer_Tick;

            // Subscribe to the ValueChanged event of numericUpDown1
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;

            // Load the image into PictureBox named "Output"
            LoadImageToOutputPictureBox();

            // Initialize file system watcher
            InitializeFileSystemWatcher();

            // Load the image into PictureBox named "Output"
            LoadImageToOutputPictureBox();

            pythonProcess = null;
        }

        private void EnsureFoldersExist()
        {
            // Create input folder if it doesn't exist
            if (!Directory.Exists(InputFolderPath))
            {
                Directory.CreateDirectory(InputFolderPath);
            }

            // Create output folder if it doesn't exist
            if (!Directory.Exists(outputFolderPath))
            {
                Directory.CreateDirectory(outputFolderPath);
            }
        }

        void StartCamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                videoCapture.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            Pic1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                videoCapture.Stop();
            }
            catch
            {
                return;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            Pic2.Image = Pic1.Image;
            string fileName = @"C:\Input\" + tbFileName.Text + ".jpg";
            var bitmap = new Bitmap(Pic2.Width, Pic2.Height);
            Pic2.DrawToBitmap(bitmap, Pic2.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = null;
            imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(fileName, imageFormat);
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            StopCamera();
        }

        private void StopCamera()
        {
            if (videoCapture != null && videoCapture.IsRunning)
            {
                videoCapture.Stop();
                Pic1.Image = null;
                Pic2.Image = null;
            }
        }

        private void BtnAutoCapture_Click(object sender, EventArgs e)
        {
            if (!autoCaptureTimer.Enabled)
            {
                autoCaptureTimer.Start();
                BtnAutoCapture.Text = "Stop Auto Capture";
            }
            else
            {
                autoCaptureTimer.Stop();
                BtnAutoCapture.Text = "Start Auto Capture";
            }
        }

        private void AutoCaptureTimer_Tick(object sender, EventArgs e)
        {
            CaptureImage();
            captureCount++;
        }

        private void CaptureImage()
        {
            Pic2.Image = Pic1.Image;
            string fileName = $@"C:\Input\capture{captureCount}.jpg";
            var bitmap = new Bitmap(Pic2.Width, Pic2.Height);
            Pic2.DrawToBitmap(bitmap, Pic2.ClientRectangle);
            System.Drawing.Imaging.ImageFormat imageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            bitmap.Save(fileName, imageFormat);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int interval = (int)numericUpDown1.Value * 1000;

            if (interval <= 0)
            {
                interval = 1000;
                numericUpDown1.Value = interval;
            }

            autoCaptureTimer.Interval = interval;
        }

        private void InitializeFileSystemWatcher()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = outputFolderPath;
            watcher.Filter = "Output.jpg";
            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;

            // Subscribe to events
            watcher.Changed += new FileSystemEventHandler(OnOutputImageChanged);
            watcher.Created += new FileSystemEventHandler(OnOutputImageChanged);
            watcher.Deleted += new FileSystemEventHandler(OnOutputImageDeleted);

            // Begin watching
            watcher.EnableRaisingEvents = true;
        }

        private void OnOutputImageChanged(object sender, FileSystemEventArgs e)
        {
            // Reload the image into PictureBox when Output.jpg is modified or created
            LoadImageToOutputPictureBox();
        }

        private void OnOutputImageDeleted(object sender, FileSystemEventArgs e)
        {
            // Clear PictureBox when Output.jpg is deleted
            Output.Image = null;
        }

        private async void LoadImageToOutputPictureBox()
        {
            try
            {
                // Check if the file exists
                if (File.Exists(outputImagePath))
                {
                    // Introduce a small delay
                    await Task.Delay(500);

                    using (FileStream fs = new FileStream(outputImagePath, FileMode.Open, FileAccess.Read))
                    {
                        // Load the image into a MemoryStream
                        using (MemoryStream ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            // Create the image from the MemoryStream
                            Image originalImage = Image.FromStream(ms);
                            // Display the image in the PictureBox
                            Output.Image = originalImage;
                        }
                    }
                }
                else
                {
                    // If file doesn't exist, clear PictureBox
                    Output.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the file exists
                if (File.Exists(outputImagePath))
                {
                    // Delete the file
                    File.Delete(outputImagePath);
                    // Clear PictureBox
                    Output.Image = null;
                    MessageBox.Show("Image deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Image not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting image: " + ex.Message);
            }
        }

        private void BtnDeleteInputs_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(InputFolderPath))
                {
                    string[] files = Directory.GetFiles(InputFolderPath);

                    foreach (string file in files)
                    {
                        File.Delete(file);
                    }

                    // Clear PictureBox if necessary
                    Pic2.Image = null;

                    MessageBox.Show("Images deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Folder not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting images: " + ex.Message);
            }
        }

        private void BtnRunPythonScript_Click(object sender, EventArgs e)
        {
            // Specify the path to the Python script
            string pythonScriptPath = @"C:\Users\johnn\senior1.py"; // Change this to your actual Python script path

            // Check if the Python script exists
            if (System.IO.File.Exists(pythonScriptPath))
            {
                // Create a process start info
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "python"; // Assuming 'python' is in the system PATH
                startInfo.Arguments = pythonScriptPath;

                // Start the process
                pythonProcess = Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("Python script not found.");
            }
        }

        private void BtnStopPythonScript_Click(object sender, EventArgs e)
        {
            // Check if the Python process is running
            if (pythonProcess != null && !pythonProcess.HasExited)
            {
                // Terminate the Python process
                pythonProcess.Kill();
                pythonProcess = null; // Reset the process variable
                MessageBox.Show("Python script stopped.");
            }
            else
            {
                MessageBox.Show("Python script is not currently running.");
            }
        }
    }
}