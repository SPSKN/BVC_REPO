using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaOfTriangle
{
    public partial class AreaOfTriangle : Form
    {
        /****************************************
         * Calculates the area of A Triangle
         * 
         * Inputs are:
         * Base
         * Height
         * 
         * Outputs are:
         * Area of The Triangle
         * 
         * -Scott Patterson
         * 
         ***************************************/


        int HeightTri = 0; // Height of Triangle
        int BaseTri = 0; // Base of Triangle
        

        public AreaOfTriangle()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            /* Exit the app */
            Application.Exit();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            /* Calculation time */
            //Get Base
            //Get Height
            //A = (B * H)/2
            //Return Area
            int.TryParse(HeightBox.Text, out HeightTri); //TryParse will return 0 if not able to parse to int
            int.TryParse(BaseBox.Text, out BaseTri); // see above comment^^
            decimal AreaTri = ((HeightTri * BaseTri) / 2); // Calculation for Arear of Triangle
            if (HeightTri == 0 || BaseTri == 0)
            {
                CalculationLb.Text = "Invalid Character";
            }
            else
            {
                CalculationLb.Text = AreaTri.ToString(); // Parse the Area into a String then put it int the Label

            }

          

        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BaseBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculationLb_Click(object sender, EventArgs e)
        {

        }
    }
}
