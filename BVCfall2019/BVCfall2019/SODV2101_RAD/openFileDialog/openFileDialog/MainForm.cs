using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace openFileDialog
{
    public partial class MainForm : Form
    {
        private StreamReader inputFile;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog getFilePathDialog = new OpenFileDialog();

            DialogResult result = getFilePathDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePathTextBox.Text = getFilePathDialog.FileName;
                try
                {
                    inputFile = new StreamReader(getFilePathDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("File has Failed to Open.");
                    return;
                }
            }
            else
            {
                filePathTextBox.Text = "User Cancelled: No Path Selected.";
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (inputFile.EndOfStream)
            {
                MessageBox.Show("You have read all the data");
                btnRead.Enabled = false;
                return;
            }
            lineFromTextBox.Text = inputFile.ReadLine();
        }
    }
}
