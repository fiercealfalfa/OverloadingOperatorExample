using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsExample
{
    class SavingsAccount
    {
        public string name;
        public decimal balance;
        
        public SavingsAccount(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
            Console.WriteLine("An Instance of the SavingsAccount class was created");
        }
    }

}
