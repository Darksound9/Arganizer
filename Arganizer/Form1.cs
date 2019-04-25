using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Arganizer
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        public string excelFilePath = "";
        public string scanPath = "";
        public int currentRow = 2;

        public int PREFIX = 1;
        public int NAME = 2;
        public int EXTENSION = 3;
        public int DIRECTORY = 4;

        ExcelPackage package = new ExcelPackage();
        ExcelWorksheet worksheet = null;

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            this.resetButton.Font = new System.Drawing.Font(this.resetButton.Font.Name, 14F);
            this.openFileButton.Font = new System.Drawing.Font(this.openFileButton.Font.Name, 14F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Set up the BackgroundWorker object by 
        // attaching event handlers. 
        private void InitializeBackgroundWorker()
        {
            this.backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            this.backgroundWorker1_RunWorkerCompleted);
        }


        private void BrowseLocationButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                CheckPathExists = true,
                AddExtension = true,
                OverwritePrompt = true,
                ValidateNames = true,
                FileName = "",
                Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls",
                Title = "Save Excel File"
            };

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                excelFilePath = saveFileDialog1.FileName;
                this.HeaderLabel.Text = excelFilePath;
                // Saves the Image via a FileStream created by the OpenFile method.  
                try
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile(); //Will fail if another app is using one you're replacing
                    // NOTE that the FilterIndex property is one-based.  
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                        case 2:
                            worksheet = package.Workbook.Worksheets.Add("Base Worksheet");
                            worksheet.Cells[1, 1].Value = "{Prefix}";
                            worksheet.Cells[1, 2].Value = "{Name}";
                            worksheet.Cells[1, 3].Value = "{Extension}";
                            worksheet.Cells[1, 4].Value = "{Directory}";
                            package.SaveAs(fs);
                            fs.Close();
                            break;
                    }

                    fs.Close();
                }
                catch (System.IO.IOException ex)
                {
                    this.HeaderLabel.Text = ex.Message;
                }
            }

            System.IO.FileStream fss = new System.IO.FileStream(excelFilePath, System.IO.FileMode.Open);
            fss.Close();
            this.DriveLabel.Visible = true;
            this.chooseADriveFolderButton.Visible = true;
            this.Height = 208;
            this.resetButton.Visible = true;
        }

        private void chooseADriveFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog
            {
                Description = "Choose a Drive/Folder"
            })
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    scanPath = fbd.SelectedPath;
                    this.DriveLabel.Text = scanPath;


                    this.ScanReadyLabel.Visible = true;
                    this.InitiateScanButton.Visible = true;
                    this.Height = 300;
                }
            }
        }

        private void InitiateScanButton_Click(object sender, EventArgs e)
        {
            this.ScanReadyLabel.Text = "Scanning, writing results to file...";
            if (this.backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                this.backgroundWorker1.RunWorkerAsync();
            }
        }

        // This event handler is where the time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            InitiateFolderScan(scanPath);
            System.IO.FileStream fss = new System.IO.FileStream(excelFilePath, System.IO.FileMode.Open);
            package.SaveAs(fss);
            fss.Close();
        }

        private void InitiateFolderScan(string currentDirectory)
        {
            string[] files = new string[0];
            //Ensure we have permission to access this directories contents
            try { files = Directory.GetFiles(currentDirectory); }
            catch { /* Ignoring... */ } //This catches all errors, access denied exceptions, etc.

            if (files.Length > 0)
            {
                foreach (string filePath in Directory.GetFiles(currentDirectory))
                {
                    WriteToExcelFile(filePath);
                }
                foreach (string dir in Directory.GetDirectories(currentDirectory))
                {
                    InitiateFolderScan(dir);
                }
            }
        }

        public void WriteToExcelFile(string filePath)
        {
            try
            {
                string fullFileName = filePath.Split('\\').Last();
                string[] splitExtension = fullFileName.Split('.');
                string name = splitExtension.First();
                string fileExtension = splitExtension.Last();

                //Begin Prefix Parsing
                string prefix = "";
                bool removeLeading = false;
                bool removeTrailing = false;
                if (name.StartsWith("A ")) { prefix = "A "; removeLeading = true; }
                else if (name.StartsWith("The ")) { prefix = "The "; removeLeading = true; }
                else if (name.StartsWith("An ")) { prefix = "An "; removeLeading = true; }
                else if (name.EndsWith(", A")) { prefix = ", A"; removeTrailing = true; }
                else if (name.EndsWith(", The")) { prefix = ", The"; removeTrailing = true; }
                else if (name.EndsWith(", An")) { prefix = ", An"; removeTrailing = true; }

                if (prefix.Length > 0)
                {
                    int removalIndex = 0;
                    if (removeLeading) { removalIndex = name.IndexOf(prefix); }
                    if (removeTrailing) { removalIndex = name.LastIndexOf(prefix); }
                    name = (removalIndex == 0 && removeLeading) || (removeTrailing)
                        ? name.Remove(removalIndex, prefix.Length)
                        : name;
                }

                worksheet.Cells[currentRow, DIRECTORY].Value = filePath;
                worksheet.Cells[currentRow, PREFIX].Value = prefix;
                worksheet.Cells[currentRow, NAME].Value = name;
                worksheet.Cells[currentRow, EXTENSION].Value = fileExtension;

                currentRow++;
            }
            catch (Exception ex)
            {
                throw new Exception("File parsing broke for file: " + filePath
                    + "Here is the exception: " + ex.Message);
            }
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                this.ScanReadyLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                this.ScanReadyLabel.Text = "Scan complete!";
                this.openFileButton.Visible = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.excelFilePath = "";
            this.scanPath = "";
            this.currentRow = 2;
            package = new ExcelPackage();
            worksheet = null;

            this.Height = 118;

            this.HeaderLabel.Text = "Welcome! Please choose a location and name for your Excel File:";
            this.DriveLabel.Text = "Excel file has been created. Please choose a drive/folder to scan:";
            this.ScanReadyLabel.Text = "Ready to scan!";

            this.DriveLabel.Visible = false;
            this.ScanReadyLabel.Visible = false;
            this.chooseADriveFolderButton.Visible = false;
            this.InitiateScanButton.Visible = false;
            this.openFileButton.Visible = false;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(excelFilePath);
        }
    }
}
