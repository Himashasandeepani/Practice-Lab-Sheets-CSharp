using System;

namespace LabSheet2_Q2
{
    // Class - BankAccount
    public class BankAccount
    {
        // Properties - accountNumber and balance
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }

        // Constructor
        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        // Method - Deposit
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount. Please enter a valid deposit amount.");
                return;
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"Successfully Deposited: {amount}. \nNew balance: {Balance}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Object
            BankAccount account = new BankAccount("123456", 1000.00);

            // Input
            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            // Deposit
            account.Deposit(amount);

            // Output
            Console.WriteLine($"Updated balance: {account.Balance}");
            Console.ReadLine();
        }
    }
}

/*
Output- 

Enter deposit amount: 5000
Successfully Deposited: 5000.
New balance: 6000
Updated balance: 6000
*/