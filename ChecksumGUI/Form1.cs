using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecksumGUI
{
    public partial class ChecksumGui : Form
    {
        String currentDir = AppDomain.CurrentDomain.BaseDirectory;
        String importPath = "";
        bool fileUploaded = false;
        bool debugMode = false;

        public ChecksumGui()
        {
            InitializeComponent();
            completeMsg.Visible = false;
            convert.Enabled = false;
            exportNavigation.Visible = false;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    importPath = ofd.FileName;
                    uploadFile.Text = Path.GetFileName(ofd.FileName);
                    fileUploaded = true;
                    writeDebug(importPath);
                }
                catch (SecurityException ex)
                {
                    fileUploaded = false;
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                } 
                finally
                {
                    convert.Enabled = fileUploaded;
                }
            }
        }

        private void convert_Click(object sender, EventArgs e)
        {
            String fileName = String.Format("{0}-READY.bin", Path.GetFileNameWithoutExtension(importPath)); 
            String exportDir = Path.GetDirectoryName(importPath); 
            String exportPath = String.Format("\"{0}\\{1}\"", exportDir, fileName);
            writeDebug(exportPath);
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = String.Format("{0}me7sum_1.1.1\\me7sum", currentDir); 
            psi.Arguments = String.Join(" ", String.Format("\"{0}\"", importPath), exportPath);
            writeDebug(psi.FileName + psi.Arguments);
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.RedirectStandardOutput = true;
            var p = new Process();
            p.StartInfo = psi;
            p.Start();
            if (debugMode)
            {
                AppendText(console, p.StandardOutput.ReadToEnd(), Color.Black, true);
            }
            else
            {
                console.ForeColor = Color.Black;
                console.Text = p.StandardOutput.ReadToEnd();
            }
            p.WaitForExit();
            exportNavigation.Visible = completeMsg.Visible = true;
        }


        private void exportNavigation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"explorer.exe", Path.GetDirectoryName(importPath));
        }

        private void debug_CheckedChanged(object sender, EventArgs e)
        {
            debugMode = debug.Checked;
        }

        private void writeDebug(String message)
        {
            if (debugMode)
            {
                AppendText(console, message, Color.Red, true);
            }
        }

        public void AppendText(RichTextBox box, string text, Color color, bool AddNewLine = false)
        {
            if (AddNewLine)
            {
                text += Environment.NewLine;
            }

            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
