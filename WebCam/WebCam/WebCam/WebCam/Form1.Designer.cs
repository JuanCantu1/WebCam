namespace WebCam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnAutoCapture = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnDeleteInputs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRunPythonScript = new System.Windows.Forms.Button();
            this.BtnStopPythonScript = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic1
            // 
            this.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic1.Location = new System.Drawing.Point(60, 12);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(199, 214);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            // 
            // Pic2
            // 
            this.Pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic2.Location = new System.Drawing.Point(339, 12);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(199, 214);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic2.TabIndex = 1;
            this.Pic2.TabStop = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(60, 232);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(91, 33);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnCapture
            // 
            this.BtnCapture.Location = new System.Drawing.Point(157, 232);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(91, 33);
            this.BtnCapture.TabIndex = 3;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = true;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(339, 245);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(199, 20);
            this.tbFileName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File Name";
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(60, 272);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(91, 33);
            this.BtnStop.TabIndex = 6;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnAutoCapture
            // 
            this.BtnAutoCapture.Location = new System.Drawing.Point(157, 274);
            this.BtnAutoCapture.Name = "BtnAutoCapture";
            this.BtnAutoCapture.Size = new System.Drawing.Size(91, 33);
            this.BtnAutoCapture.TabIndex = 7;
            this.BtnAutoCapture.Text = "Auto Capture";
            this.BtnAutoCapture.UseVisualStyleBackColor = true;
            this.BtnAutoCapture.Click += new System.EventHandler(this.BtnAutoCapture_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 325);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seconds between captures";
            // 
            // Output
            // 
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Output.Location = new System.Drawing.Point(611, 12);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(199, 214);
            this.Output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Output.TabIndex = 11;
            this.Output.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Output";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(664, 245);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(91, 33);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Delete File";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDeleteInputs
            // 
            this.BtnDeleteInputs.Location = new System.Drawing.Point(380, 270);
            this.BtnDeleteInputs.Name = "BtnDeleteInputs";
            this.BtnDeleteInputs.Size = new System.Drawing.Size(91, 33);
            this.BtnDeleteInputs.TabIndex = 14;
            this.BtnDeleteInputs.Text = "Delete Files";
            this.BtnDeleteInputs.UseVisualStyleBackColor = true;
            this.BtnDeleteInputs.Click += new System.EventHandler(this.BtnDeleteInputs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Delete Output File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Delete Input Files";
            // 
            // BtnRunPythonScript
            // 
            this.BtnRunPythonScript.Location = new System.Drawing.Point(60, 350);
            this.BtnRunPythonScript.Name = "BtnRunPythonScript";
            this.BtnRunPythonScript.Size = new System.Drawing.Size(91, 33);
            this.BtnRunPythonScript.TabIndex = 17;
            this.BtnRunPythonScript.Text = "Run Script";
            this.BtnRunPythonScript.UseVisualStyleBackColor = true;
            this.BtnRunPythonScript.Click += new System.EventHandler(this.BtnRunPythonScript_Click);
            // 
            // BtnStopPythonScript
            // 
            this.BtnStopPythonScript.Location = new System.Drawing.Point(157, 350);
            this.BtnStopPythonScript.Name = "BtnStopPythonScript";
            this.BtnStopPythonScript.Size = new System.Drawing.Size(91, 33);
            this.BtnStopPythonScript.TabIndex = 18;
            this.BtnStopPythonScript.Text = "Stop Script";
            this.BtnStopPythonScript.UseVisualStyleBackColor = true;
            this.BtnStopPythonScript.Click += new System.EventHandler(this.BtnStopPythonScript_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 389);
            this.Controls.Add(this.BtnStopPythonScript);
            this.Controls.Add(this.BtnRunPythonScript);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDeleteInputs);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.BtnAutoCapture);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Pic2);
            this.Controls.Add(this.Pic1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnAutoCapture;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnDeleteInputs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRunPythonScript;
        private System.Windows.Forms.Button BtnStopPythonScript;
    }
}

