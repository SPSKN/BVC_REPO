using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Covertor
{
    /*
     * Unit Converter
     * fall2019
     * --Rapid App Development
     * 2019-09-11
     * -Scott Patterson
     * */
    public partial class unitConvert : Form
    {
        Double iCelsius, iFahrenheit, iKelvin;

       // bool tempConverter = false; // mode for the temperature Convertion
        

        public unitConvert()
        {
            InitializeComponent();
        }

        private void unitConvert_Load(object sender, EventArgs e)
        {
            //Input Combo Box
            InputDisplay.Text = "0";
            Cmb1.Items.Add("Celsius");
            Cmb1.Items.Add("Fahrenheit");
            Cmb1.Items.Add("Kelvin");
            

            //Converter Combo Box
            Cmb2.Items.Add("Celsius");
            Cmb2.Items.Add("Fahrenheit");
            Cmb2.Items.Add("Kelvin");
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //do not use this
        }

        private void Cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do not use this
            CalculateTemp();//Runs the calculation everytime the Combo Box's Item is changed
        }

        private void Cmb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTemp();//Runs the calculation everytime the Combo Box's Item is changed
            // do not use this
        }

        private void TemperatureButton(object sender, EventArgs e)
        {
            //Buttons
            Button TemperatureButton = (Button)sender;
            if(InputDisplay.Text == "0")
            {
                InputDisplay.Text = "";

            }//Buttons

            if (TemperatureButton.Text == ".")

            {
                if (!InputDisplay.Text.Contains("."))
                {
                    InputDisplay.Text = InputDisplay.Text + TemperatureButton.Text;
                }

            }//Buttons
            else
            {
                InputDisplay.Text = InputDisplay.Text + TemperatureButton.Text;
            }//Buttons
            CalculateTemp();//Runs the calculation everytime the button is pressed, as the number changes, the new value is calculated
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //CE Button Clears both Displays
            InputDisplay.Text = "";
            ConvertedDisplay.Text = "";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //DEL Button removes the last Input(String) from the Label-Ary[]
            InputDisplay.Text=InputDisplay.Text.Remove(InputDisplay.Text.Length -1,1);
            if(InputDisplay.Text == "")
            {
                InputDisplay.Text = "0";
            }
            CalculateTemp();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(InputDisplay.Text.Contains("-"))
            {
                InputDisplay.Text = InputDisplay.Text.Remove(0, 1);
            }
            else
            {
                InputDisplay.Text = "-" + InputDisplay.Text;
            }
            CalculateTemp();
        }
        private void CalculateTemp()
        {
            /* Calculation for Temperatures
             * Takes the Text from the InputDisplay and Parse it into a double
             * Displays Converted Units
             * -Scott Patterson
             * */
             if(InputDisplay.Text == "" || InputDisplay.Text ==" ")//This Handles any null values before calculation ;)
            {
                InputDisplay.Text ="0";
            }
               //Celsius
            if (Cmb1.Text == "Celsius" && Cmb2.Text == "Fahrenheit")
            {
                iCelsius = Double.Parse(InputDisplay.Text);
                ConvertedDisplay.Text = Math.Round((((iCelsius * 9) / 5) + 32)).ToString();

            }
            else if (Cmb1.Text == "Celsius" && Cmb2.Text == "Kelvin")
            {
                iCelsius = Double.Parse(InputDisplay.Text);
                ConvertedDisplay.Text = Math.Round(iCelsius + 273.15).ToString();
            }
            //Fahrenheit
            else if (Cmb1.Text == "Fahrenheit" && Cmb2.Text == "Celsius")
            {
                iFahrenheit = Double.Parse(InputDisplay.Text);
                ConvertedDisplay.Text = Math.Round((((iFahrenheit - 32) * 5) / 9)).ToString();
            }
            else if(Cmb1.Text == "Fahrenheit" && Cmb2.Text =="Kelvin")
            {
                iFahrenheit = Double.Parse(InputDisplay.Text);
                ConvertedDisplay.Text = Math.Round((((iCelsius * 9) / 5) + 32) + 273.15).ToString();
            }
            //Kelvin
            else if(Cmb1.Text == "Kelvin" && Cmb2.Text == "Celsius")
            {
                iKelvin = Double.Parse(InputDisplay.Text);
                ConvertedDisplay.Text = Math.Round(iKelvin - 273.15).ToString();
            }
            else if(Cmb1.Text =="Kelvin" && Cmb2.Text =="Fahrenheit")
            {
                iKelvin = Double.Parse(InputDisplay.Text);
                iCelsius = iKelvin - 273.15;
                ConvertedDisplay.Text = Math.Round((((iCelsius * 9) / 5) + 32)).ToString();
            }
            else
            {
                ConvertedDisplay.Text = InputDisplay.Text;
            }
        }


    }
}
