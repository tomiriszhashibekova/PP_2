using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double resV = 0;
        string operationP = "";
        bool isOperationP = false;
        public Form1()
        {
            InitializeComponent();
        }
         private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")  || (isOperationP))
            
                textBox1.Clear();
                isOperationP = false;
                Button button=  (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                textBox1.Text = textBox1.Text + button.Text;
            }
            else 
            textBox1.Text = textBox1.Text + button.Text;
            
        }
        private void operator_click_even(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(resV!= 0)
            {
                Equal.PerformClick();
                operationP = button.Text;
                isOperationP = true;
            }   
            else
            {
            operationP = button.Text;
                resV = double.Parse(textBox1.Text);
                isOperationP = true;
            }
            
            
            
        }

        private void Equal_Click(object sender, EventArgs e)
        {
             switch (operationP)
                {
                case "+":
                    textBox1.Text=(resV + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resV - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resV * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resV / double.Parse(textBox1.Text)).ToString();
                    break;
              
                case "x^2":
                    textBox1.Text = (double.Parse(textBox1.Text)*double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
               }
            resV= Double.Parse(textBox1.Text);
        }
        private void prosent_Click(object sender, EventArgs e)
        {
                       textBox1.Text = (resV + resV * (double.Parse(textBox1.Text) / 100)).ToString();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //x^2
            textBox1.Text = (double.Parse(textBox1.Text) * double.Parse(textBox1.Text)).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {    
            if (isOperationP != true)
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else if(isOperationP != false)
            {
                textBox1.Text = "+" + textBox1.Text;
            }
        }
       


        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resV = 0;
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {
        
            resV = Math.Sqrt(resV);
            textBox1.Text = resV.ToString();


        }

        private void wqqw(object sender, EventArgs e)
        {
            textBox1.Text = (1 / resV).ToString();
        }
    }
}
