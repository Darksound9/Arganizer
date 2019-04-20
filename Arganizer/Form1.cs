using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arganizer
{
    public partial class Form1 : Form
    {
        public string excelFileName = "";
        public string scanPath = "";
        public int currentRow = 2;

        ExcelPackage package = new ExcelPackage();
        ExcelWorksheet worksheet;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                excelFileName = saveFileDialog1.FileName;
                this.HeaderLabel.Text = excelFileName;
                // Saves the Image via a FileStream created by the OpenFile method.  
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // NOTE that the FilterIndex property is one-based.  
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                    case 2:
                        worksheet = package.Workbook.Worksheets.Add("Base Worksheet");
                        worksheet.Cells[1, 1].Value = "Directory";
                        worksheet.Cells[1, 2].Value = "Prefix";
                        worksheet.Cells[1, 3].Value = "Name";
                        worksheet.Cells[1, 4].Value = "Extension";
                        package.SaveAs(fs);
                        fs.Close();
                        break;
                }

                fs.Close();
            }

            System.IO.FileStream fss = new System.IO.FileStream(excelFileName, System.IO.FileMode.Open);
            fss.Close();
            this.DriveLabel.Visible = true;
            this.chooseADriveFolderButton.Visible = true;
            this.Height = 208;
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
            InitiateFolderScan(scanPath);
        }

        private void InitiateFolderScan(string currentDirectory)
        {
            foreach (string filePath in Directory.GetFiles(currentDirectory))
            {
                //string[] splitBySlash = filePath.Split("//");
            }
            foreach(string dir in Directory.GetDirectories(currentDirectory))
            {
                InitiateFolderScan(dir);
            }
        }
    }
}
