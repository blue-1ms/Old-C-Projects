using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class fmTax : Form
    {
        public fmTax()
        {
            InitializeComponent();
        }
            private void btnCalc_Click(object sender, EventArgs e)
        {
            double income, tax;
            if (!(double.TryParse(textIncome.Text, out income)))
            {
                MessageBox.Show("You must enter a number, Please try again!");
                return;
            }
            if (income <= 18200)
            {
                tax = 0;
                textTax.Text = ("Tax = ") + tax;
            }
            else if (income <= 37000)
            {
                tax = (income - 18200) * 0.19;
                textTax.Text = ("Tax = ") + tax;
            }
            else if (income <= 80000)
            {
                tax = 3572 + (income - 37001) * 0.325;
                textTax.Text = ("Tax = ") + tax;
            }
            else if (income <= 180000)
            {
                tax = 17547 + (income - 80000) * 0.37;
                textTax.Text = ("Tax = ") + tax;
            }
            else if (income >= 180001)
            {
                tax = 54547 + (income - 180000) * 0.45;
                textTax.Text = ("Tax = ") + tax;
            }
        }
    }
}
    
