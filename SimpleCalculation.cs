using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class SimpleCalculation : Form
    {
        public static String inputSt = "";
        
       
        public SimpleCalculation()
        {
            InitializeComponent();

           
        }
        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputSt = tbInput.Text;
                if (!String.IsNullOrEmpty(inputSt))
                {
                    if (Regex.IsMatch(inputSt, @"^[^0-9,-][0-9]+$")|| 
                        Regex.IsMatch(inputSt, @"^[0-9][^0-9,-][0-9]+$")|| 
                        Regex.IsMatch(inputSt, @"^[0-9][^0-9,-]+$"))
                    {
                        MessageBox.Show("Mix of numbers and letters cannot be calculated \nPlease try a comma insted of point");
                        tbInput.Text = "";
                    }
                    
                    if (Regex.IsMatch(inputSt, @"[0-9]+$")&& !(Regex.IsMatch(inputSt, @"^[^0-9,-][0-9]+$") ||
                        Regex.IsMatch(inputSt, @"^[0-9][^0-9,-][0-9]+$") ||
                        Regex.IsMatch(inputSt, @"^[0-9][^0-9,-]+$")))
                    {
                        Calculations calc = new Calculations();

                        calc.Show();
                        this.Hide();
                    }
                }

                else
                {
                    MessageBox.Show("Enter a value to calculate");
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            inputSt = tbInput.Text;
            if (!String.IsNullOrEmpty(inputSt))
            {
                if (Regex.IsMatch(inputSt, @"^[^0-9.-]+$"))
                {
                    MessageBox.Show("Only numbers can be calculated");
                    tbInput.Text = "";
                }
                if (Regex.IsMatch(inputSt, @"^[^0-9,-][0-9]+$") ||
                    Regex.IsMatch(inputSt, @"[0-9][^0-9,-][0-9]+$") ||
                    Regex.IsMatch(inputSt, @"[0-9][^0-9,-]+$"))
                {
                    MessageBox.Show("Mix of numbers and letters cannot be calculated \nPlease try a comma insted of point");
                    tbInput.Text = "";
                }

               

                if (Regex.IsMatch(inputSt, @"[0-9]+$") && !(Regex.IsMatch(inputSt, @"^[^0-9,-][0-9]+$") ||
                        Regex.IsMatch(inputSt, @"^[0-9][^0-9,-][0-9]+$") ||
                        Regex.IsMatch(inputSt, @"^[0-9][^0-9,-]+$")))
                {
                    Calculations calc = new Calculations();

                    calc.Show();
                    this.Hide();
                }
            }

            else
            {
                    MessageBox.Show("Enter a value to calculate");
                }
            
        }
    }
}
