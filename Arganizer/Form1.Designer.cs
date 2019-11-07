namespace Arganizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.CreateExcelFileButton = new System.Windows.Forms.Button();
            this.DriveLabel = new System.Windows.Forms.Label();
            this.chooseADriveFolderButton = new System.Windows.Forms.Button();
            this.ScanReadyLabel = new System.Windows.Forms.Label();
            this.InitiateScanButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.resetButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.scanDirectoriesOnly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(16, 11);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(418, 17);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Welcome! Please choose a location and name for your Excel File:";
            // 
            // CreateExcelFileButton
            // 
            this.CreateExcelFileButton.Location = new System.Drawing.Point(129, 44);
            this.CreateExcelFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateExcelFileButton.Name = "CreateExcelFileButton";
            this.CreateExcelFileButton.Size = new System.Drawing.Size(151, 36);
            this.CreateExcelFileButton.TabIndex = 4;
            this.CreateExcelFileButton.Text = "Create Excel File";
            this.CreateExcelFileButton.UseVisualStyleBackColor = true;
            this.CreateExcelFileButton.Click += new System.EventHandler(this.BrowseLocationButton_Click);
            // 
            // DriveLabel
            // 
            this.DriveLabel.AutoSize = true;
            this.DriveLabel.Location = new System.Drawing.Point(16, 102);
            this.DriveLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DriveLabel.Name = "DriveLabel";
            this.DriveLabel.Size = new System.Drawing.Size(420, 17);
            this.DriveLabel.TabIndex = 5;
            this.DriveLabel.Text = "Excel file has been created. Please choose a drive/folder to scan:";
            this.DriveLabel.Visible = false;
            // 
            // chooseADriveFolderButton
            // 
            this.chooseADriveFolderButton.Location = new System.Drawing.Point(107, 149);
            this.chooseADriveFolderButton.Margin = new System.Windows.Forms.Padding(4);
            this.chooseADriveFolderButton.Name = "chooseADriveFolderButton";
            this.chooseADriveFolderButton.Size = new System.Drawing.Size(195, 36);
            this.chooseADriveFolderButton.TabIndex = 6;
            this.chooseADriveFolderButton.Text = "Choose a Drive/Folder";
            this.chooseADriveFolderButton.UseVisualStyleBackColor = true;
            this.chooseADriveFolderButton.Visible = false;
            this.chooseADriveFolderButton.Click += new System.EventHandler(this.chooseADriveFolderButton_Click);
            // 
            // ScanReadyLabel
            // 
            this.ScanReadyLabel.AutoSize = true;
            this.ScanReadyLabel.Location = new System.Drawing.Point(16, 214);
            this.ScanReadyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ScanReadyLabel.Name = "ScanReadyLabel";
            this.ScanReadyLabel.Size = new System.Drawing.Size(102, 17);
            this.ScanReadyLabel.TabIndex = 7;
            this.ScanReadyLabel.Text = "Ready to scan!";
            this.ScanReadyLabel.Visible = false;
            // 
            // InitiateScanButton
            // 
            this.InitiateScanButton.Location = new System.Drawing.Point(129, 249);
            this.InitiateScanButton.Margin = new System.Windows.Forms.Padding(4);
            this.InitiateScanButton.Name = "InitiateScanButton";
            this.InitiateScanButton.Size = new System.Drawing.Size(151, 39);
            this.InitiateScanButton.TabIndex = 8;
            this.InitiateScanButton.Text = "Begin Scan";
            this.InitiateScanButton.UseVisualStyleBackColor = true;
            this.InitiateScanButton.Visible = false;
            this.InitiateScanButton.Click += new System.EventHandler(this.InitiateScanButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(288, 44);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(40, 36);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "↰ ";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(288, 249);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(40, 39);
            this.openFileButton.TabIndex = 10;
            this.openFileButton.Text = "⌕";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Visible = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // scanDirectoriesOnly
            // 
            this.scanDirectoriesOnly.AutoSize = true;
            this.scanDirectoriesOnly.Location = new System.Drawing.Point(129, 299);
            this.scanDirectoriesOnly.Name = "scanDirectoriesOnly";
            this.scanDirectoriesOnly.Size = new System.Drawing.Size(167, 21);
            this.scanDirectoriesOnly.TabIndex = 11;
            this.scanDirectoriesOnly.Text = "Scan Directories Only";
            this.scanDirectoriesOnly.UseVisualStyleBackColor = true;
            this.scanDirectoriesOnly.Visible = false;
            this.scanDirectoriesOnly.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(451, 94);
            this.Controls.Add(this.scanDirectoriesOnly);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.InitiateScanButton);
            this.Controls.Add(this.ScanReadyLabel);
            this.Controls.Add(this.chooseADriveFolderButton);
            this.Controls.Add(this.DriveLabel);
            this.Controls.Add(this.CreateExcelFileButton);
            this.Controls.Add(this.HeaderLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Arganizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button CreateExcelFileButton;
        private System.Windows.Forms.Label DriveLabel;
        private System.Windows.Forms.Button chooseADriveFolderButton;
        private System.Windows.Forms.Label ScanReadyLabel;
        private System.Windows.Forms.Button InitiateScanButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.CheckBox scanDirectoriesOnly;
    }
}

