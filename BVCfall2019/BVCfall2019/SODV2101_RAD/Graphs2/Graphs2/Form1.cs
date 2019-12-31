using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs2
{


    public partial class Form1 : Form
    {
       // public List<InputClass> inputList = new List<InputClass>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string x = inputBox.Text;
            string l = legendBox.Text;
            InputClass a = new InputClass(x);
            this.chart.Series["Series1"].Points.AddXY(l,a.input);
            inputBox.Clear();
            legendBox.Clear();
        }

      
    }
}
