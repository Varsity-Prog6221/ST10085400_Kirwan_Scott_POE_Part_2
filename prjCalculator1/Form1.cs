using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculator1
{
    public partial class Form1 : Form
    {
        double num1;
        string operation;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtShow.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtShow.Text== "0" && txtShow.Text != null)
            {
                txtShow.Text = "1";
            }
            else
            {
                txtShow.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" && txtShow.Text != null)
            {
                txtShow.Text = "2";
            }
            else
            {
                txtShow.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" && txtShow.Text != null)
            {
                txtShow.Text = "3";
            }
            else
            {
                txtShow.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" && txtShow.Text != null)
            {
                txtShow.Text = "4";
            }
            else
            {
                txtShow.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" && txtShow.Text != null)
            {
                txtShow.Text = "5";
            }
            else
            {
                txtShow.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" && txtShow.Text != null)
            {
                txtShow.Text = "6";
            }
            else
            {
                txtShow.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" && txtShow.Text != null)
            {
                txtShow.Text = "7";
            }
            else
            {
                txtShow.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" && txtShow.Text != null)
            {
                txtShow.Text = "8";
            }
            else
            {
                txtShow.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtShow.Text == "0" && txtShow.Text != null)
            {
                txtShow.Text = "9";
            }
            else
            {
                txtShow.Text += "9";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtShow.Text);
            txtShow.Text = "0";
            operation = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtShow.Text);
            txtShow.Text = "0";
            operation = "-";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtShow.Text);
            txtShow.Text = "0";
            operation = "/";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtShow.Text);
            txtShow.Text = "0";
            operation = "*";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num2;
            double result;

            num2 = Convert.ToDouble(txtShow.Text);

            
                if (operation == "+")
                {
                    result = (num1 + num2);
                    txtShow.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (operation == "-")
                {
                    result = (num1 - num2);
                    txtShow.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (operation == "*")
                {
                    result = (num1 * num2);
                    txtShow.Text = Convert.ToString(result);
                    num1 = result;
                }
                if (operation == "/")
                {
                    if (num2 == 0)
                    {
                        txtShow.Text = "ERROR!";
                    }
                    else
                    {
                        result = (num1 / num2);
                        txtShow.Text = Convert.ToString(result);
                        num1 = result;
                    }
                }
            
        }

        

        private void txtShow_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtShow.Text = "0";
        }
    }
}
