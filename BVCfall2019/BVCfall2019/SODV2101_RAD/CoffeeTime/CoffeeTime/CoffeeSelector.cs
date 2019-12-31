using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeTime
{
    public partial class CoffeeSelector : UserControl
    {
        public String cSize
        {
            get { return coffeeSize.Text; }
        }
        public String cMilk
        {
            get { return numericUpDown1.Value.ToString(); }
        }
        public String cCream
        {
            get { return numericUpDown2.Value.ToString(); }
        }
        public String cSugar
        {
            get { return numericUpDown3.Value.ToString(); }
        }
        public String cWhip
        {
            get { if (checkBox1.Checked == true)
                    return "With Cream";
                else
                {
                    return "No Cream";
                }
                        }
        }
       public  int[] ReturnArray = new int[5];
        public CoffeeSelector()
        {
            InitializeComponent();
        }

        private void CoffeeSelector_Load(object sender, EventArgs e)
        {
          //  string[] coffee = new string[5];
            coffeeSize.Items.Add("Small");
            coffeeSize.Items.Add("Medium");
            coffeeSize.Items.Add("Large");
            ///for each time COFFEE is clicked a NEW coffee string is made and
        }
        
        private void MilkCounter_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CoffeeSize_ValueMemberChanged(object sender, EventArgs e)
        {

        }
    }
}
