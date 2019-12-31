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
    public partial class DonutCounter : UserControl
    {
        public DonutCounter()
        {
            InitializeComponent();
        }
        public String dValue
        {
            get { return donutUpDown.Value.ToString(); }
        }
                                
        private void DonutUpDown_ValueChanged(object sender, EventArgs e)
        {

            /// I know this is lazy but it works
            if (donutUpDown.Value == 2)
            { donutUpDown.Value = 6; }
            else if (donutUpDown.Value == 7)
            { donutUpDown.Value = 12; }
            else if (donutUpDown.Value == 13)
            { donutUpDown.Value = 24; }
            else if(donutUpDown.Value==23)
            { donutUpDown.Value = 12; }
            else if(donutUpDown.Value ==11)
            { donutUpDown.Value = 6; }
            else if(donutUpDown.Value == 5)
            { donutUpDown.Value = 1; }
        }

        private void DonutCounter_Load(object sender, EventArgs e)
        {

            //Max and Min values
            donutUpDown.Maximum = 24;
            donutUpDown.Minimum = 1;
         

            
         }
    }
}
