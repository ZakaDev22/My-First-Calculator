using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__My_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enCharOptions
        {
          enPlus = 1, enSub=2,  enMult=3, enDiv=4
        };

        
        private double result = 0;
        private string firstChoise ;
        private string secondChoise ;
        private byte char1 = 0;
        private double LastResult = 0;
     

        private void PerformCalcChoise(enCharOptions options)
        {
            switch(options)
            {
                case enCharOptions.enPlus:
                    result = Convert.ToDouble(firstChoise) + Convert.ToDouble(secondChoise);
                    LastResult = result;
                    break;

                case enCharOptions.enSub:
                    result = Convert.ToDouble(firstChoise) - Convert.ToDouble(secondChoise);
                    LastResult = result;
                    break;

                case enCharOptions.enMult:
                    result = Convert.ToDouble(firstChoise) * Convert.ToDouble(secondChoise);
                    LastResult = result;
                    break;

                case enCharOptions.enDiv:
                    result = Convert.ToDouble(firstChoise) / Convert.ToDouble(secondChoise);
                    LastResult = result;
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btn1.Text;
                txtResults.Text += btn1.Text;
            }
            else
            {
                secondChoise += btn1.Text;
                txtResults.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btn2.Text;
                txtResults.Text += btn2.Text;
            }
            else
            {
                secondChoise += btn2.Text;
                txtResults.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0 )
            {
                firstChoise += btn3.Text;
                txtResults.Text += btn3.Text;
            }
            else
            {
                secondChoise += btn3.Text;
                txtResults.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btn4.Text;
                txtResults.Text += btn4.Text;
            }
            else
            {
                secondChoise += btn4.Text;
                txtResults.Text += btn4.Text;
            }
            }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btn5.Text;
                txtResults.Text += btn5.Text;
            }
            else
            {
                secondChoise += btn5.Text;
                txtResults.Text += btn5.Text;
            }

            }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += Convert.ToInt32(btn6.Text);
                txtResults.Text += btn6.Text;
            }
            else
            {
                secondChoise += btn6.Text;
                txtResults.Text += btn6.Text;
            }
            }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btn7.Text;
                txtResults.Text += btn7.Text;
            }
            else
            {
                secondChoise += btn7.Text;
                txtResults.Text += btn7.Text;
            }
            }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btn8.Text;
                txtResults.Text += btn8.Text;
            }
            else
            {
                secondChoise += btn8.Text;
                txtResults.Text += btn8.Text;
            }
            }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btn9.Text;
                txtResults.Text += btn9.Text;
            }
            else
            {
                secondChoise += btn9.Text;
                txtResults.Text += btn9.Text;
            }
            }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btn0.Text;
                txtResults.Text += btn0.Text;
            }
            else
            {
                secondChoise += btn0.Text;
                txtResults.Text += btn0.Text;
            }
            }

        private void btnNote_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise += btnNote.Text;
                txtResults.Text += btnNote.Text;
            }
            else
            {
                secondChoise += btnNote.Text;
                txtResults.Text += btnNote.Text;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
            {
                 MessageBox.Show("Click Clear Button To Perform Another Result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PerformCalcChoise((enCharOptions)char1);

            txtResults.Text += " = " + result.ToString();

            btnResult.Tag = 1;
            btnPlus.Tag = 1;
            btnSubtract.Tag = 1;
            btnMultiplay.Tag = 1;
            btnDivide.Tag = 1;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(Convert.ToByte( btnPlus.Tag) == 1)
            {
                MessageBox.Show("Click Clear Button To Perform Another Result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtResults.Text += " + ";
            char1 = 1;
            btnPlus.Tag = 1;
            
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnSubtract.Tag) == 1)
            {
                MessageBox.Show("Click Clear Button To Perform Another Result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtResults.Text += " - ";
            char1 = 2;
            btnSubtract.Tag = 1;

        }

        private void btnMultiplay_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnMultiplay.Tag) == 1)
            {
                MessageBox.Show("Click Clear Button To Perform Another Result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            txtResults.Text += " x ";
            char1 = 3;
            btnMultiplay.Tag = 1;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnDivide.Tag) == 1)
            {
                MessageBox.Show("Click Clear Button To Perform Another Result", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtResults.Text += " / ";
            char1 = 4;
            btnDivide.Tag = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResults.Clear();

            result = 0;
            firstChoise = "";
            secondChoise = "";
            char1 = 0;

            btnPlus.Tag = 0;
            btnSubtract.Tag = 0;
            btnMultiplay.Tag = 0;
            btnDivide.Tag = 0;
            btnResult.Tag = 0;

        }

        private void btnLastResult_Click(object sender, EventArgs e)
        {
            if (Convert.ToByte(btnResult.Tag) == 1)
                return;

            if (char1 == 0)
            {
                firstChoise = LastResult.ToString();
                txtResults.Text = LastResult.ToString();
            }
            else
            {
                secondChoise = LastResult.ToString();
                txtResults.Text += LastResult.ToString();
            }

        }
    }
}
