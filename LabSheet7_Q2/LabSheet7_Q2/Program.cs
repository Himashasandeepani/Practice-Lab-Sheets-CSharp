using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet7_Q2
{
    //abstract class - BankAccount
    public abstract class BankAccount
    {
        //variable
        protected double balance;

        //constructor
        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        //abstract method -deposit
        public abstract void Deposit(double amount);

        //abstract method - withdraw
        public abstract void Withdraw(double amount);

        //display balance - method
        public void DisplayBalance()
        {
            Console.WriteLine("The balance: " + balance);
        }
    }

    //child class - SavingsAccount
    public class SavingsAccount : BankAccount
    {
        //constant rate
        private const double InterestRate = 0.04;

        //constructor
        public SavingsAccount(double initialBalance) : base(initialBalance)
        {
        }

        //override method - deposit
        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C} into Savings Account");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        //override method - withdraw
        public override void Withdraw(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from Savings Account");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public void AddInterest()
        {
            double interest = balance * InterestRate;
            balance += interest;
            Console.WriteLine($"Added interest {interest:C} to Savings Account");
        }
    }

    //child class - CurrentAccount
    public class CurrentAccount : BankAccount
    {
        //constant rate
        private const double OverdraftLimit = 1000.00;

        //constructor
        public CurrentAccount(double initialBalance) : base(initialBalance)
        {
        }

        //override method - deposit
        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C} into Current Account");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        //override method - withdraw
        public override void Withdraw(double amount)
        {
            if (amount > 0 && (balance + OverdraftLimit) >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount:C} from Current Account");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or overdraft limit exceeded.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(1000.00);
            CurrentAccount current = new CurrentAccount(500.00);

            savings.Deposit(200.00);
            savings.Withdraw(150.00);
            savings.AddInterest();
            savings.DisplayBalance();

            current.Deposit(300.00);
            current.Withdraw(700.00);
            current.DisplayBalance();

            Console.ReadLine();
        }
    }
}
