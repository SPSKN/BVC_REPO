using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace newTextEditor
{
    public partial class Form1 : Form
    {
        public Form1(string title)
        {
            Name = title;
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to do SAVE FILE
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save";
            sfd.CheckFileExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter SW = new StreamWriter(sfd.FileName))
                {
                    string line = TextBox.Text;
                    SW.WriteLine(line);
                }
            }
        }
        int fileNumber = 1;
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newWindow = new Form1("File" + fileNumber);
            //newWindow.MdiParent = this;
            newWindow.Show();
            fileNumber++;

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to do OPEN FILE
            OpenFileDialog ofd = new OpenFileDialog();

                if(ofd.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = File.ReadAllText(ofd.FileName);
            }
            else
            {
                MessageBox.Show("No Path Selected");
            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to do add a SAVE HERE

            Close();

        }

        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
