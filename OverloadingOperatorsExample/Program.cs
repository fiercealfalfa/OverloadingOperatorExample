using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Standard use of the + Operator");
            //int number_one = 5;
            //int number_two = 7;
            //int number_three;
            //number_three = number_two + number_one;
            //Console.WriteLine(number_three);
            //Console.ReadKey();
            Console.WriteLine("Setting up two instances of the Account Class");
            Account first_account = new Account("Andrew", 250, 5000);
            Account second_account = new Account("Mike", 700, 2342);
            Console.WriteLine("First Account Information:\n Name: {0} Balance: {1}", first_account.name, first_account.balance);
            Console.WriteLine("Second Account Information:\n Name: {0} Balance: {1}", second_account.name, second_account.balance);
            Console.ReadKey();
            Console.WriteLine("Adding the two instances together");
            Account combined_account;
            combined_account = first_account + second_account;
            Console.WriteLine("First Account Information:\n Name: {0} Balance: {1}", first_account.name, first_account.balance);
            Console.WriteLine("Second Account Information:\n Name: {0} Balance: {1}", second_account.name, second_account.balance);
            Console.WriteLine("Combined Account Information:\n Name: {0} Balance: {1}", combined_account.name, combined_account.balance);
            Console.ReadKey();
            Console.WriteLine("Adding instances from two different classes together");
            SavingsAccount savings_account = new SavingsAccount("Nick", 10000);
            Account another_combined_account;
            another_combined_account = first_account + savings_account;
            Console.WriteLine("First Account Information:\n Name: {0} Balance: {1}", first_account.name, first_account.balance);
            Console.WriteLine("Another Combined Account Information:\n Name: {0} Balance: {1}", another_combined_account.name, another_combined_account.balance);
            Console.ReadKey();
            Console.WriteLine("Just because we can");
            Account combine_all_the_things;
            combine_all_the_things = combined_account + another_combined_account;
            Console.WriteLine("Combine All The Things Account Information:\n Name: {0} Balance: {1}", combine_all_the_things.name, combine_all_the_things.balance);
            Console.ReadKey();
        }
    }
}
