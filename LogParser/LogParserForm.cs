using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LogParser
{
    public partial class LogParserForm : Form
    {
        public LogParserForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                lblNoFile.Text = string.Empty;
                txtBox.Visible = true;
                txtBox.Text = string.Empty;
                lblSearchedFor.Visible = false;
                string searchText = txtSearch.Text.Trim();
                if (searchText == string.Empty)
                {
                    searchText = "write protected memory";
                }

                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;

                DialogResult result = folderDlg.ShowDialog();

                // look for all files with an extension of "log"

                string[] files = System.IO.Directory.GetFiles(folderDlg.SelectedPath, "*.log");

                if (files.Length == 0)
                {
                    lblNoFile.Visible = true;
                    txtBox.Visible = false;
                    lblNoFile.Text = "No files with an extension of '.log' found in the selected directory..";
                }

                // if log files found, loop thru each file to find the search text
                foreach (string file in files)
                {
                    lblSearchedFor.Visible = true;
                    lblSearchedFor.Text = "You Searched for '" + searchText + "'";
                    string text = File.ReadAllText(file).ToLower();
                    int times = Regex.Matches(text, searchText).Count;
                    txtBox.Font = new Font(FontFamily.GenericSerif, 14);
                    int fileName = file.LastIndexOf("\\");
                    txtBox.Text += "File Name: " + file.Substring(fileName).Replace("\\","") + System.Environment.NewLine + "Number of Occurences: " + times + System.Environment.NewLine;
                    txtBox.Text += System.Environment.NewLine;
                }
            }

            catch (Exception ex)
            {
                lblNoFile.Text = ex.Message.ToString();
            }
        }
    }
}
