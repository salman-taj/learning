using System;

namespace ConsoleApp.Models
{
    public enum AccountType
    {
        Saving = 1,
        Current
    }
    public class BankAccount
    {
        public static int Total = 0;
        public BankAccount(string _title, string _code, AccountType _accountType)
        {
            Title = _title;
            code = _code;
            CreatedOn = DateTime.Now;
            AccountType = _accountType;
            Total += 1;
        }
        
        
        // Data
        // title
        private string title;

        public string Title
        {
            get { return title; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new Exception("Invalid title of account");
                }
                
                title = value;
            }
        }
        
        // account number / code
        private string code;

        public string Code
        {
            get { return code; }
        }
        
        // created On
        public DateTime CreatedOn { get; }
        
        // type: Saving / Current
        public AccountType AccountType { get; }
        
        // balance
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            private set
            {
                balance = value;
            }
        }

        // Functions
        // Pay In
        public bool PayIn(decimal amount)
        {
            if (amount < 0)
            {
                return false;
            }

            // Balance = Balance + amount;
            Balance += amount;
            return true;
        }
        
        // With Draw 
        public bool WithDraw(decimal amount)
        {
            if (amount > Balance)
            {
                return false;
            }

            Balance -= amount;
            return true;
        }
    }
}