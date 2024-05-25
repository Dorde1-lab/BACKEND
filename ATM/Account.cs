using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public abstract class Account : IAccount
    {

        public string AccountNumber {  get; set; }
        public string Pin {  get; set; }
        public double Balance { get; set; }

        public Account(string accountNumber, string pin, double initialBalance)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Balance = initialBalance;
        }

        public abstract void Deposit(double amount);


        public abstract void Withdraw(double amount);
       

        public  bool ValidatePin(string pin)
        {
            return Pin == pin;

        }


    }
}
