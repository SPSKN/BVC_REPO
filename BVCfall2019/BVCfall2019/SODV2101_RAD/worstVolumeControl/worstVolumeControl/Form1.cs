using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worstVolumeControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            volBar.Value = volBar.Value+10;
        }

        private void VolBar_Click(object sender, EventArgs e)
        {

        }

        private void VolDown_Click(object sender, EventArgs e)
        {
            volBar.Value = volBar.Value - 10;
        }

        private void MuteBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AppName_Click(object sender, EventArgs e)
        {

        }
    }
}
