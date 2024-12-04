using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Account
    {
        public int AccNo { get; set; }
        public double Amount { get; set; }
        public Action<double, double> SmallAmount;
        public override string ToString()
        {
            return "Account: " + AccNo + ", Current balance: " + Amount;
        }
        public void Deposit(double money)
        {
            Amount += money;
        }
        public void Withdraw(double money)
        {
            if (Amount >= money)
            {
                Amount -= money;
            }
            else
            {
                SmallAmount(money,Amount);
            }
        }
    }
}
