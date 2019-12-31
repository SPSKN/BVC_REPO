using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeTime
{
    public partial class Form1 : Form
    {
        public List<CoffeeSelector> Coffee = new List<CoffeeSelector>();
        public List<DonutCounter> Donut = new List<DonutCounter>();

        public Form1()
        {
            InitializeComponent();
        }

        private void DonutBtn_Click(object sender, EventArgs e)
        {
            DonutCounter Dnuts = new DonutCounter();

            Dnuts.Dock = DockStyle.Bottom;
            listP.Controls.Add(Dnuts);
            Donut.Add(Dnuts);
        }

        private void CoffeeBtn_Click(object sender, EventArgs e)
        {
            CoffeeSelector Cs = new CoffeeSelector();
            Cs.Dock = DockStyle.Bottom;
            listP.Controls.Add(Cs);
            Coffee.Add(Cs);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rb1_Click(object sender, EventArgs e)
        {
            foreach (CoffeeSelector C in Coffee)
            {
                TB1.Text += C.cSize;
                TB1.Text += " ,";
                TB1.Text += "Milk: " + C.cMilk;
                TB1.Text += " ,";
                TB1.Text += "Cream: " + C.cCream;
                TB1.Text += " ,";
                TB1.Text += "Sugar: " + C.cSugar;
                TB1.Text += " ,";
                TB1.Text += C.cWhip;
                TB1.Text += Environment.NewLine;



            }
            foreach (DonutCounter D in Donut)
            {
                TB1.Text += "Donuts: " + D.dValue;
                TB1.Text += Environment.NewLine;

            }

            /// The Coffee Logo
            TB1.Text += "         (   ";
            TB1.Text += Environment.NewLine;
            TB1.Text += "        ) )  ";
            TB1.Text += Environment.NewLine;
            TB1.Text += "     ******";
            TB1.Text += Environment.NewLine;
            TB1.Text += "     **  **  ]";
            TB1.Text += Environment.NewLine;
            TB1.Text += "     **  **  ]";
            TB1.Text += Environment.NewLine;
            TB1.Text += "     ******";
            TB1.Text += Environment.NewLine;
            listP.Controls.Clear();
            Donut.Clear();
            Coffee.Clear();
        }
    }
}
