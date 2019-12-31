using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;

namespace MediaMusic
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private Video video;
        private string[] videoPath;
        private string[] folderPath = {"C:/User/knight"};
        private int selectedIndex = 0;
        private Size formSize;
        private Size pnlSize;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // player.URL;
            // axWindowsMediaPlayer1.URL = "20190313_190557.mp4";
            // axWindowsMediaPlayer1.Ctlcontrols.play();

            /*
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(pnlVideo.Width, pnlVideo.Height);

            videoPaths = Directory.GetFiles(folderPath, "*.wmv");

            if (videoPaths != null)
            {
                foreach (string path in videoPaths)
                {
                    string vid = path.Replace(folderPath, string.Empty);
                    vid = vid.Replace(".wmv", string.Empty);
                    lstVideos.Items.Add(vid);
                }
            }
            lstVideos.SelectedIndex = selectedIndex;

            */
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*
            player.URL = "Sparkle.mp3";
            player.controls.play();
            */

            //Pervious Button
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*
            player.controls.stop();
            */

            // Play/Pause

            if (!video.Playing)
            {
                video.Play();
                timer.Enabled = true;
                //Button2.Text = "Pause";
            }
            else if(video.Playing)
            {
                video.Pause();
                timer.Enabled = false;
                //
                //Button2.Text = "Play";
            }

        }

        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
           // ignore this one
        }

        private void AxWindowsMediaPlayer1_Enter_1(object sender, EventArgs e)
        {
            //ignore this one
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //Fullscreen
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            video.Owner = this;
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Next
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Volume
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
