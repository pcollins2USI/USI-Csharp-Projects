/* Patrick Collins
 * Windows Form Calculator
 * 1/10/2019
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculPATC
{
    public partial class Form1 : Form
    {
        Double Number1 = 0;
        String operation = "";
        bool operation_pressed = false;
        bool errorTest = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text != ".")
            {
                textBox1.Text += (sender as Button).Text;
            }
            else if (errorTest)
            {
                errorTest = false;
                textBox1.Text += (sender as Button).Text;
            }
            else
            {
                MessageBox.Show("No more than one decimal");
            }

            
        }

        private void add_Click(object sender, EventArgs e)
        {
            operation = (sender as Button).Text;
            Number1 = Double.Parse(textBox1.Text);
            operation_pressed = true;
            errorTest = true;
            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (Number1 + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (Number1 - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (Number1 * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(textBox1.Text) != 0)
                    {
                        textBox1.Text = (Number1 / Double.Parse(textBox1.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Undefined");
                    }
                    
                    break;
                default:
                    break;
            }//end of the switch statement
            operation_pressed = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            errorTest = true;
            textBox1.Clear();
        }
    }
}
