using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsExample
{
    class Account
    {
        public string name;
        public decimal balance;
        public decimal credit_limit;

        public Account(string name, decimal balance, decimal credit_limit)
        {
            this.name = name;
            this.balance = balance;
            this.credit_limit = credit_limit;
            Console.WriteLine("An Instance of the Account Class was created");
        }

        public Account()
        {

        }
        //Overloading the plus operator requires a static method in the class that defines the objects you want to add together
        //
        public static Account operator +(Account account_one, Account account_two)
        { 
            Account combined_account = new Account();
            combined_account.name = account_one.name + " " + account_two.name;
            combined_account.balance = account_one.balance + account_two.balance;
            combined_account.credit_limit = account_one.credit_limit + account_two.credit_limit;
            Console.WriteLine("As long as I return an object of type account, I can do whatever I want in this method");
            return combined_account;
        }
        public static Account operator +(Account account, SavingsAccount savings_account)
        {
            Account combined_account = new Account();
            combined_account.name = account.name + " " + savings_account.name;
            combined_account.balance = account.balance + savings_account.balance;
            combined_account.credit_limit = account.credit_limit;
            return combined_account;
        }
    }
}
