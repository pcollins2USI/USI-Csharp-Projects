using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_Bank
{
    //Negative Balance
    class NegativeBalanceException : Exception
    {
        public NegativeBalanceException()
        {
            System.Windows.Forms.MessageBox.Show("Insufficient funds");
        }
    }
    //Negative Deposit
    class NegativeDepositException : Exception
    {
        public NegativeDepositException()
        {
            System.Windows.Forms.MessageBox.Show("Despoite is a negative number and it is not allowed");
        }
    }
    //Too Large
    class TooLargeException : Exception
    {
        public TooLargeException()
        {
            System.Windows.Forms.MessageBox.Show("A deposit or withdrawal is more than $1,000.00. This is not allowed by your bank.");
        }
    }
    //Negative Withdraw
    class NegativeWithdrawException : Exception
    {
        public NegativeWithdrawException()
        {
            System.Windows.Forms.MessageBox.Show("Negative withdraws are not allowed.");
        }
    }
}
