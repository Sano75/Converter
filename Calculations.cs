using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Calculations : Form
    {
        Double input = Convert.ToDouble(SimpleCalculation.inputSt.Trim());
      

        public Calculations()
        {
            InitializeComponent();
            labels();
        }
       

        private void labels()
        {
            lblResult.Text = "Calculations of " + input;
            lblMeterFoot.Text = "Meters makes "+Math.Round((input* 3.2808399),3)+" Foot";
            lblFootMeter.Text = "Foot makes " + Math.Round((input / 3.2808399),3)+" Meters";
            lblFtoC.Text = "Farenheit makes " + Math.Round((((input-32)*5)/9), 3) + " Celsius";
            lblCtoF.Text = "Celsius makes " + Math.Round((((input*9)/5)+32), 3) + " Farenheit";
            lblLtoGal.Text = "Liter makes " + Math.Round((input * 0.26417205236), 3) + " Galon";
            lblGaToLiter.Text = "Galon makes " + Math.Round((input / 0.26417205236), 3) + " Liter";
            lblKgToPounds.Text = "Kg makes " + Math.Round((input* 2.2046226218), 3) + " Pounds (lbs)";
            lblPoundsToKg.Text = "Pounds makes " + Math.Round((input / 2.2046226218), 3) + " Kg";
            lblKwToHk.Text = "Kw makes " + Math.Round((input/ 0.7457), 3) + " Mechanical Hp";
            lblHkToKw.Text = "Mechanical Hp " + Math.Round((input* 0.7457), 3) + " Kw";
            lblKwToEHp.Text = "Kw makes " + Math.Round((input / 0.746), 3) + " Electrical Hp";
            lblEhpToKw.Text = "Electrical Hp " + Math.Round((input * 0.746), 3) + " Kw";
            lblMeterToYards.Text = "Meters makes " + Math.Round((input* 1.0936133), 3) + " Yards";
            lblYardsToMeter.Text = "Yards makes " + Math.Round((input / 1.0936133), 3) + " Meters";
            lblMtoSq.Text = "Sq Meters makes " + Math.Round((input * 10.763910417),3) + " Sq F";
            lblSqToM.Text = "Sq Foot makes " + Math.Round((input / 10.763910417), 3) + " Sq M";


        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleCalculation newClac = new SimpleCalculation();
            newClac.Show();
            this.Hide();
        }

       
    }
}
