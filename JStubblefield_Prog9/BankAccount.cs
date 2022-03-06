/*Jason Stubblefield
 * Program 9, Due 3/13/18
 * Partner names: None
 * Description: This program allows the user to enter bank account information
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace JStubblefield_Prog9
{
    class BankAccount
    {
        private int account;
        private decimal balance;
        private string owner;
        private bool savings;

        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }

        public int Account
        {
            get
            {
                return account;
            }
        }

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public bool Savings
        {
            get
            {
                return savings;
            }
            set
            {
                savings = value;
            }
        }

        public BankAccount()
        {
            owner = "Need a name";
        }

        public BankAccount(string name, int number, decimal amount, bool sving)
        {
            owner = name;
            savings = sving;
            SetAccount(number);
            UpdateBalance(amount, true);
        }

        public void SetAccount(int num)
        {
            while (num < 0)
            {
                Write("Not an acceptable account number.  Enter new number:  ");
                num = int.Parse(ReadLine());
            }
            account = num;
        }

        public void UpdateBalance(decimal amount, bool deposit)
        {
            if (deposit == true)
            {
                while (amount < 0)
                {
                    Write("Amount may not be less than $0.00.  Enter new amount to deposit: ");
                    amount = decimal.Parse(ReadLine());
                }
                balance += amount;
            }
            else
            {
                while (amount < 0 || amount > balance)
                {
                    if (amount < 0)
                    {
                        Write("Amount may not be less than $0.00.  Enter new amount to withdraw: ");
                    }
                    else if (amount > balance)
                    {
                        Write("Amount desired is greater than current balance of {0:C}.  Enter new amount to withdraw: ", balance);
                    }
                    amount = decimal.Parse(ReadLine());
                }
                balance -= amount;
            }
        }

        public override string ToString()
        {
            string result = "\nAccount Information\n\nAccount Number:  " + account +
                "\nAccount Owner:  " + owner + "\nBalance:  " + balance + "\n";
            if (savings == true)
            {
                result += "This is a savings account.\n\n";
            }
            else
            {
                result += "This is a checking account.\n\n";
            }
            return result;
        }
    }
}
