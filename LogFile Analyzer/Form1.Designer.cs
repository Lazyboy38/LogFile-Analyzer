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
            comboError = new ComboBox();
            logFileDialog = new OpenFileDialog();
            btProcess = new Button();
            lbSearchFor = new Label();
            groupBox1 = new GroupBox();
            rbV315 = new RadioButton();
            rbV314 = new RadioButton();
            btChooseLog = new Button();
            tbFilePath = new TextBox();
            groupBox2 = new GroupBox();
            checkShowDupe = new CheckBox();
            checkShowTime = new CheckBox();
            checkShowArticle = new CheckBox();
            openFileDialog2 = new OpenFileDialog();
            label1 = new Label();
            tbFailedTires = new TextBox();
            lbIssues = new Label();
            tbOther = new TextBox();
            lbOther = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboError
            // 
            comboError.FormattingEnabled = true;
            comboError.Items.AddRange(new object[] { "Model not found", "Postvalidation fail", "Prevalidation fail", "All Errors (can take long)", "Other" });
            comboError.Location = new Point(12, 32);
            comboError.Margin = new Padding(3, 4, 3, 4);
            comboError.Name = "comboError";
            comboError.Size = new Size(247, 27);
            comboError.TabIndex = 0;
            comboError.SelectedIndexChanged += comboError_SelectedIndexChanged;
            // 
            // logFileDialog
            // 
            logFileDialog.DefaultExt = "txt";
            logFileDialog.FileName = "logFileDialog";
            logFileDialog.InitialDirectory = "@\"C:\\\"";
            logFileDialog.RestoreDirectory = true;
            logFileDialog.Title = "Browse customer logfiles on your PC";
            // 
            // btProcess
            // 
            btProcess.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btProcess.Location = new Point(12, 405);
            btProcess.Margin = new Padding(3, 4, 3, 4);
            btProcess.Name = "btProcess";
            btProcess.Size = new Size(152, 44);
            btProcess.TabIndex = 1;
            btProcess.Text = "Process Logfile";
            btProcess.UseVisualStyleBackColor = true;
            btProcess.Click += btProcess_Click;
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
            groupBox1.Location = new Point(12, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(143, 87);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "4Jet HMI Version:";
            // 
            // rbV315
            // 
            rbV315.AutoSize = true;
            rbV315.Location = new Point(6, 55);
            rbV315.Name = "rbV315";
            rbV315.Size = new Size(118, 23);
            rbV315.TabIndex = 1;
            rbV315.Text = "4Jet HMI 3.15";
            rbV315.UseVisualStyleBackColor = true;
            // 
            // rbV314
            // 
            rbV314.AutoSize = true;
            rbV314.Checked = true;
            rbV314.Location = new Point(6, 26);
            rbV314.Name = "rbV314";
            rbV314.Size = new Size(118, 23);
            rbV314.TabIndex = 0;
            rbV314.TabStop = true;
            rbV314.Text = "4Jet HMI 3.14";
            rbV314.UseVisualStyleBackColor = true;
            // 
            // btChooseLog
            // 
            btChooseLog.Location = new Point(12, 371);
            btChooseLog.Name = "btChooseLog";
            btChooseLog.Size = new Size(152, 27);
            btChooseLog.TabIndex = 4;
            btChooseLog.Text = "Choose Logfile";
            btChooseLog.UseVisualStyleBackColor = true;
            btChooseLog.Click += btChooseLog_Click;
            // 
            // tbFilePath
            // 
            tbFilePath.Location = new Point(170, 371);
            tbFilePath.Name = "tbFilePath";
            tbFilePath.Size = new Size(732, 27);
            tbFilePath.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkShowDupe);
            groupBox2.Controls.Add(checkShowTime);
            groupBox2.Controls.Add(checkShowArticle);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 140);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Options:";
            // 
            // checkShowDupe
            // 
            checkShowDupe.AutoSize = true;
            checkShowDupe.Location = new Point(6, 84);
            checkShowDupe.Name = "checkShowDupe";
            checkShowDupe.Size = new Size(141, 23);
            checkShowDupe.TabIndex = 2;
            checkShowDupe.Text = "Show Duplicates";
            checkShowDupe.UseVisualStyleBackColor = true;
            // 
            // checkShowTime
            // 
            checkShowTime.AutoSize = true;
            checkShowTime.Location = new Point(6, 55);
            checkShowTime.Name = "checkShowTime";
            checkShowTime.Size = new Size(145, 23);
            checkShowTime.TabIndex = 1;
            checkShowTime.Text = "Show Timestamp";
            checkShowTime.UseVisualStyleBackColor = true;
            // 
            // checkShowArticle
            // 
            checkShowArticle.AutoSize = true;
            checkShowArticle.Checked = true;
            checkShowArticle.CheckState = CheckState.Checked;
            checkShowArticle.Location = new Point(6, 26);
            checkShowArticle.Name = "checkShowArticle";
            checkShowArticle.Size = new Size(150, 23);
            checkShowArticle.TabIndex = 0;
            checkShowArticle.Text = "Show Tire Articles";
            checkShowArticle.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 10);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 8;
            label1.Text = "Problematic Tires:";
            // 
            // tbFailedTires
            // 
            tbFailedTires.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbFailedTires.Location = new Point(265, 32);
            tbFailedTires.Multiline = true;
            tbFailedTires.Name = "tbFailedTires";
            tbFailedTires.ScrollBars = ScrollBars.Vertical;
            tbFailedTires.Size = new Size(637, 313);
            tbFailedTires.TabIndex = 9;
            // 
            // lbIssues
            // 
            lbIssues.AutoSize = true;
            lbIssues.Location = new Point(265, 280);
            lbIssues.Name = "lbIssues";
            lbIssues.Size = new Size(0, 19);
            lbIssues.TabIndex = 10;
            // 
            // tbOther
            // 
            tbOther.Enabled = false;
            tbOther.Location = new Point(12, 85);
            tbOther.Name = "tbOther";
            tbOther.Size = new Size(247, 27);
            tbOther.TabIndex = 11;
            // 
            // lbOther
            // 
            lbOther.AutoSize = true;
            lbOther.Enabled = false;
            lbOther.Location = new Point(12, 63);
            lbOther.Name = "lbOther";
            lbOther.Size = new Size(92, 19);
            lbOther.TabIndex = 12;
            lbOther.Text = "Other Error:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 462);
            Controls.Add(lbOther);
            Controls.Add(tbOther);
            Controls.Add(lbIssues);
            Controls.Add(tbFailedTires);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(tbFilePath);
            Controls.Add(btChooseLog);
            Controls.Add(groupBox1);
            Controls.Add(lbSearchFor);
            Controls.Add(btProcess);
            Controls.Add(comboError);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboError;
        private OpenFileDialog logFileDialog;
        private Button btProcess;
        private Label lbSearchFor;
        private GroupBox groupBox1;
        private RadioButton rbV315;
        private RadioButton rbV314;
        private Button btChooseLog;
        private TextBox tbFilePath;
        private GroupBox groupBox2;
        private CheckBox checkShowArticle;
        private CheckBox checkShowTime;
        private CheckBox checkShowDupe;
        private OpenFileDialog openFileDialog2;
        private Label label1;
        private TextBox tbFailedTires;
        private Label lbIssues;
        private TextBox tbOther;
        private Label lbOther;
    }
}
