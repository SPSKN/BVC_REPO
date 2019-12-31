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
using System.Media;

namespace media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //pictureBox.ImageLocation = ofd.FileName; // old and slow
                Image image = Image.FromFile(ofd.FileName); //new and hot
               // pictureBox.Image = image; //new and hot
                //pictureBox.ImageLocation = "C:/Users/knight/...; // for a file path
                this.BackgroundImage = image;
                
            }
            */
            Image image = new Bitmap("C:/Users/knight/Pictures/sub.png");
            this.BackgroundImage = image;

        }

        private void SoundButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("C:/Windows/Media/ding.wav");
            player.Play();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MusicButton_Click(object sender, EventArgs e)
        {

        }
    }
}
