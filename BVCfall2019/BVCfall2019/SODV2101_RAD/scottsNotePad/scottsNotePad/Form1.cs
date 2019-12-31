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

namespace scottsNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //to do OPEN FILE
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = File.ReadAllText(ofd.FileName);
            }
            else
            {
                MessageBox.Show("No Path Selected");
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newWindow = new Form1();
            //newWindow.MdiParent = this;
            newWindow.Show();
            //fileNumber++;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();

            sdf.Title = "Save";

            if (sdf.ShowDialog() == DialogResult.OK)
            {


                using (StreamWriter SW = new StreamWriter(sdf.FileName))
                {
                    string line = TextBox.Text;
                    SW.WriteLine(line);
                }
            }


        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdf = new SaveFileDialog();

            sdf.Title = "Save As";

            if (sdf.ShowDialog() == DialogResult.OK)
            {


                using (StreamWriter SW = new StreamWriter(sdf.FileName))
                {
                    string line = TextBox.Text;
                    SW.WriteLine(line);
                }
            }


        }
    }
}
