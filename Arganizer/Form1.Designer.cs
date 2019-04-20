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
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(316, 13);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Welcome! Please choose a location and name for your Excel File:";
            // 
            // CreateExcelFileButton
            // 
            this.CreateExcelFileButton.Location = new System.Drawing.Point(97, 36);
            this.CreateExcelFileButton.Name = "CreateExcelFileButton";
            this.CreateExcelFileButton.Size = new System.Drawing.Size(113, 29);
            this.CreateExcelFileButton.TabIndex = 4;
            this.CreateExcelFileButton.Text = "Create Excel File";
            this.CreateExcelFileButton.UseVisualStyleBackColor = true;
            this.CreateExcelFileButton.Click += new System.EventHandler(this.BrowseLocationButton_Click);
            // 
            // DriveLabel
            // 
            this.DriveLabel.AutoSize = true;
            this.DriveLabel.Location = new System.Drawing.Point(12, 83);
            this.DriveLabel.Name = "DriveLabel";
            this.DriveLabel.Size = new System.Drawing.Size(318, 13);
            this.DriveLabel.TabIndex = 5;
            this.DriveLabel.Text = "Excel file has been created. Please choose a drive/folder to scan:";
            this.DriveLabel.Visible = false;
            // 
            // chooseADriveFolderButton
            // 
            this.chooseADriveFolderButton.Location = new System.Drawing.Point(80, 121);
            this.chooseADriveFolderButton.Name = "chooseADriveFolderButton";
            this.chooseADriveFolderButton.Size = new System.Drawing.Size(146, 29);
            this.chooseADriveFolderButton.TabIndex = 6;
            this.chooseADriveFolderButton.Text = "Choose a Drive/Folder";
            this.chooseADriveFolderButton.UseVisualStyleBackColor = true;
            this.chooseADriveFolderButton.Visible = false;
            this.chooseADriveFolderButton.Click += new System.EventHandler(this.chooseADriveFolderButton_Click);
            // 
            // ScanReadyLabel
            // 
            this.ScanReadyLabel.AutoSize = true;
            this.ScanReadyLabel.Location = new System.Drawing.Point(12, 174);
            this.ScanReadyLabel.Name = "ScanReadyLabel";
            this.ScanReadyLabel.Size = new System.Drawing.Size(79, 13);
            this.ScanReadyLabel.TabIndex = 7;
            this.ScanReadyLabel.Text = "Ready to scan!";
            this.ScanReadyLabel.Visible = false;
            // 
            // InitiateScanButton
            // 
            this.InitiateScanButton.Location = new System.Drawing.Point(97, 207);
            this.InitiateScanButton.Name = "InitiateScanButton";
            this.InitiateScanButton.Size = new System.Drawing.Size(113, 32);
            this.InitiateScanButton.TabIndex = 8;
            this.InitiateScanButton.Text = "Begin Scan";
            this.InitiateScanButton.UseVisualStyleBackColor = true;
            this.InitiateScanButton.Visible = false;
            this.InitiateScanButton.Click += new System.EventHandler(this.InitiateScanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(338, 78);
            this.Controls.Add(this.InitiateScanButton);
            this.Controls.Add(this.ScanReadyLabel);
            this.Controls.Add(this.chooseADriveFolderButton);
            this.Controls.Add(this.DriveLabel);
            this.Controls.Add(this.CreateExcelFileButton);
            this.Controls.Add(this.HeaderLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

