using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5_Bank
{

    public partial class TrustBank : Form
    {
        public TrustBank()
        {
            InitializeComponent();
            BankAccount.Store = 0;
        }

        //Depoit Event
        private void depositB_Click(object sender, EventArgs e)
        {
            try
            {
                BankAccount brokeDude = new BankAccount();
                double depositeAm = 0;
                double.TryParse(showBox.Text, out depositeAm);
                if (string.IsNullOrEmpty(showBox.Text))
                {
                    MessageBox.Show("Invalid entry");
                }
                else if (depositeAm < 0)
                {
                    //from Custom_Ex class
                    throw new NegativeDepositException();
                }
                else if (depositeAm >= 1000)
                {
                    //from Custom_Ex class
                    throw new TooLargeException();
                }
                else
                {
                    //Stores Amount in static property
                    BankAccount.Store = brokeDude.Add(depositeAm);
                }
                showBox.Clear();
            }
            catch (NegativeDepositException)
            {
                showBox.Clear();
            }
            catch (TooLargeException)
            {
                showBox.Clear();
            }
        }
        //Balance Event
        private void balanceB_Click(object sender, EventArgs e)
        {
            showBox.Clear();
            showBox.Text = BankAccount.Store.ToString();
        }
        //Withdraw Event
        private void withdrawB_Click(object sender, EventArgs e)
        {
            try
            {
                BankAccount brokeDude = new BankAccount();
                double withdrawAm = 0;
                double.TryParse(showBox.Text, out withdrawAm);
                brokeDude.BalanceTemp = brokeDude.Subtract(withdrawAm);  
                if (string.IsNullOrEmpty(showBox.Text))
                {
                    MessageBox.Show("Invalid entry");
                }
                else if (brokeDude.BalanceTemp < 0 && withdrawAm < 1000)
                {
                    //from Custom_Ex class
                    throw new NegativeBalanceException();
                }
                else if (withdrawAm >= 1000)
                {
                    //from Custom_Ex class
                    throw new TooLargeException();
                }
                else if (withdrawAm < 0)
                {
                    //from Custom_Ex class
                    throw new NegativeWithdrawException();
                }
                else
                {
                    BankAccount.Store = brokeDude.BalanceTemp;
                }
                showBox.Clear();
            }
            catch (NegativeBalanceException)
            {
                showBox.Clear();
            }
            catch (TooLargeException)
            {
                showBox.Clear();
            }
            catch (NegativeDepositException)
            {
                showBox.Clear();
            }
            catch (NegativeWithdrawException)
            {
                showBox.Clear();
            }

        }

        private void showBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    //Bank Account Class
    public class BankAccount
    {

        public string Name { get; set; }
        public double BalanceTemp { get; set; }
        public static double Store { get; set; }
        public BankAccount()
        {
            Name = "User";
            BalanceTemp = Store;
        }
        public double Add(double input)
        {
            double result = Store + input;
            return result;
        }
        public double Subtract(double input)
        {
            double result = Store - input;
            return result;
        }
    }

}

