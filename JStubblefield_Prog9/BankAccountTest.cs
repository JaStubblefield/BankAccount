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
    class BankAccountTest
    {
        static void Main(string[] args)
        {
            int option = 0;
            BankAccount myAccount = new BankAccount();
            Greeting();

            while (option != 6)
            {
                DisplayMenu();
                option = GetChoice();
                switch (option)
                {
                    case 1:
                        myAccount = CreateAccount();
                        break;
                    case 2:
                        myAccount.UpdateBalance(GetAmount("Deposit"), true);
                        break;
                    case 3:
                        myAccount.UpdateBalance(GetAmount("Withdraw"), false);
                        break;
                    case 4:
                        WriteLine("Your balance is: {0:C}\n", myAccount.Balance);
                        break;
                    case 5:
                        Write(myAccount);
                        break;
                    case 6:
                        break;
                    default:
                        WriteLine("Not a valid choice.  Try again.");
                        break;
                }
            }
        }

        public static void Greeting()
        {
            Write("Welcome to First National Bank\n");
        }

        public static void DisplayMenu()
        {
            WriteLine("\n1) Create New Account");
            WriteLine("2) Deposit");
            WriteLine("3) Withdrawal");
            WriteLine("4) Check Balance");
            WriteLine("5) Print Account");
            WriteLine("6) End Program\n");
        }

        public static int GetChoice()
        {
            Write("Enter number for your action:  ");
            int choice = int.Parse(ReadLine());
            return choice;
        }

        public static BankAccount CreateAccount()
        {
            bool savings;

            Write("\nWhat is the customer's name:  ");
            string name = ReadLine();

            Write("What is the account number:  ");
            int number = int.Parse(ReadLine());

            Write("What is the balance?  ");
            decimal balance = decimal.Parse(ReadLine());

            Write("Is this a savings or checking account?  ");
            string choice = ReadLine();

            if (choice == "savings" || choice == "Savings")
            {
                savings = true;
            }
            else
            {
                savings = false;
            }

            BankAccount myAccount = new BankAccount(name, number, balance, savings);
            return myAccount;
        }

        public static decimal GetAmount(string choice)
        {
            if (choice == "Deposit")
            {
                Write("How much do you want to deposit?  ");
            }
            else
            {
                Write("How much do you want to withdraw?  ");
            }
            return decimal.Parse(ReadLine());
        }
    }
}
