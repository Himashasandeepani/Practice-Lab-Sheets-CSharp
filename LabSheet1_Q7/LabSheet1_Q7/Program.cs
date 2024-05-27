using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet1_Q7
{
    internal class Program
    {
        //atm machine
        static decimal balance = Convert.ToDecimal(1000.00);

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("ATM Menu, ");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        DepositMoney();
                        break;
                    case "3":
                        WithdrawMoney();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            Console.ReadLine();
        }

        //checkbalance method
        static void CheckBalance()
        {
            Console.WriteLine("Your current balance is: {0}", balance);
        }

        static void DepositMoney()
        {
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount;

            if (decimal.TryParse(Console.ReadLine(), out depositAmount) && depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine("Successfully deposited {0}. \nYour new balance is: {1}", depositAmount, balance);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }

        static void WithdrawMoney()
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal withdrawAmount;

            if (decimal.TryParse(Console.ReadLine(), out withdrawAmount))
            {
                if (withdrawAmount > 0 && withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    Console.WriteLine("Successfully withdrew {0}. \nYour new balance is: {1}", withdrawAmount, balance);
                }
                else if (withdrawAmount > balance)
                {
                    Console.WriteLine("Insufficient funds. Your current balance is: {0}", balance);
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a positive number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }
    }
}

/*
Output-

ATM Menu,
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Please select an option: 1
Your current balance is: 1000
ATM Menu,
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Please select an option: 2
Enter the amount to deposit: 3000
Successfully deposited 3000.
Your new balance is: 4000
ATM Menu,
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Please select an option: 3
Enter the amount to withdraw: 5000
Insufficient funds. Your current balance is: 4000
ATM Menu,
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Please select an option: 3000
Invalid choice. Please select a valid option.
ATM Menu,
1. Check Balance
2. Deposit Money
3. Withdraw Money
4. Exit
Please select an option: 4
*/