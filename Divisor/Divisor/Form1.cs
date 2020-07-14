using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Divisor
{
    public partial class fmDivision : Form
    {
        public fmDivision()
        {
            InitializeComponent();
        }
        private void btnClick_Click(object sender, EventArgs e)
        {
            int numberLoops, divisor, answer;
            answer = 0;
            numberLoops = int.Parse(textNumber.Text);
            divisor = int.Parse(textDivisor.Text);
            lbAnswer.Items.Clear();
            for (int i = divisor; i <= numberLoops; i++)
            {
                if (i % divisor == 0)
                {
                    answer = i;
                    lbAnswer.Items.Add(answer.ToString());
                }
            }
        }
    }
}
     
