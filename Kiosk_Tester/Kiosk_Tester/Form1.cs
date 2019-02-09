using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Text = "0.00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Coffee\t\t\t$2.00");
            label5.Text = (Convert.ToDouble(label5.Text.Trim(new Char[] { '$' })) + 2.00).ToString();
            foreach (string s in checkedListBox3.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
            for (int i = 0; i < checkedListBox3.CheckedIndices.Count; i++)
            {
                if (checkedListBox3.CheckedIndices[i] == 2 || checkedListBox3.CheckedIndices[i] == 4)
                {
                    double total = (Convert.ToDouble(label5.Text.Trim(new Char[] { '$' })) + 0.75);
                    label5.Text = String.Format("{0:c}",total);
                }
                else if (checkedListBox3.CheckedIndices[i] == 3)
                {
                    double total = (Convert.ToDouble(label5.Text.Trim(new Char[] { '$' })) + 0.50);
                    label5.Text = String.Format("{0:c}", total);
                }
            }
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemChecked(i, false);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                double total = (Convert.ToDouble(label5.Text.Trim(new Char[] { '$' })) + 2.00);
                label5.Text = String.Format("{0:c}", total);
            }
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Tea\t\t\t$2.00");
            label5.Text = (Convert.ToDouble(label5.Text.Trim(new Char[] { '$' })) + 2.00).ToString();
            label5.Text = String.Format("{0:c}", Convert.ToDouble(label5.Text));
            foreach (string s in checkedListBox2.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
            for (int i = 0; i < checkedListBox2.CheckedIndices.Count; i++)
            {
                if (checkedListBox2.CheckedIndices[i] == 2)
                {
                    double total = (Convert.ToDouble(label5.Text.Trim(new Char[] { '$' })) + 0.75);
                    label5.Text = String.Format("{0:c}", total);
                }

                
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemChecked(i, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "$0.00";
            listBox1.Items.Clear();
            listBox1.Items.Add("Items\t\t\tPrice");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order has been placed.\nAmount charged is " + label5.Text);
            label5.Text = "$0.00";
            listBox1.Items.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
