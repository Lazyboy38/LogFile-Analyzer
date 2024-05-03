namespace LogFile_Analyzer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            btProcess = new Button();
            lbSearchFor = new Label();
            groupBox1 = new GroupBox();
            rbV314 = new RadioButton();
            rbV315 = new RadioButton();
            btChooseLog = new Button();
            tbFilePath = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Model not found", "other" });
            comboBox1.Location = new Point(12, 32);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 27);
            comboBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btProcess
            // 
            btProcess.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProcess.Location = new Point(12, 340);
            btProcess.Margin = new Padding(3, 4, 3, 4);
            btProcess.Name = "btProcess";
            btProcess.Size = new Size(152, 44);
            btProcess.TabIndex = 1;
            btProcess.Text = "Process Logfile";
            btProcess.UseVisualStyleBackColor = true;
            // 
            // lbSearchFor
            // 
            lbSearchFor.AutoSize = true;
            lbSearchFor.Location = new Point(12, 9);
            lbSearchFor.Name = "lbSearchFor";
            lbSearchFor.Size = new Size(192, 19);
            lbSearchFor.TabIndex = 2;
            lbSearchFor.Text = "Choose error to search for:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbV315);
            groupBox1.Controls.Add(rbV314);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(143, 87);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "4Jet HMI Version:";
            // 
            // rbV314
            // 
            rbV314.AutoSize = true;
            rbV314.Location = new Point(6, 26);
            rbV314.Name = "rbV314";
            rbV314.Size = new Size(118, 23);
            rbV314.TabIndex = 0;
            rbV314.TabStop = true;
            rbV314.Text = "4Jet HMI 3.14";
            rbV314.UseVisualStyleBackColor = true;
            // 
            // rbV315
            // 
            rbV315.AutoSize = true;
            rbV315.Location = new Point(6, 55);
            rbV315.Name = "rbV315";
            rbV315.Size = new Size(118, 23);
            rbV315.TabIndex = 1;
            rbV315.TabStop = true;
            rbV315.Text = "4Jet HMI 3.15";
            rbV315.UseVisualStyleBackColor = true;
            // 
            // btChooseLog
            // 
            btChooseLog.Location = new Point(12, 305);
            btChooseLog.Name = "btChooseLog";
            btChooseLog.Size = new Size(152, 27);
            btChooseLog.TabIndex = 4;
            btChooseLog.Text = "Choose Logfile";
            btChooseLog.UseVisualStyleBackColor = true;
            // 
            // tbFilePath
            // 
            tbFilePath.Location = new Point(170, 305);
            tbFilePath.Name = "tbFilePath";
            tbFilePath.Size = new Size(732, 27);
            tbFilePath.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(tbFilePath);
            Controls.Add(btChooseLog);
            Controls.Add(groupBox1);
            Controls.Add(lbSearchFor);
            Controls.Add(btProcess);
            Controls.Add(comboBox1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private OpenFileDialog openFileDialog1;
        private Button btProcess;
        private Label lbSearchFor;
        private GroupBox groupBox1;
        private RadioButton rbV315;
        private RadioButton rbV314;
        private Button btChooseLog;
        private TextBox tbFilePath;
    }
}
