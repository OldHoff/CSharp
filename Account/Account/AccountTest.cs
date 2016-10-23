using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AccountTest
    {
        // Main method begins execution of C# app
        public static void Main(string[] args )
        {
            Account account1 = new Account(50.00M);
            Account account2 = new Account(-7.53M);

            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}", account2.Balance);

            decimal depositAmount;

            // promt
            Console.Write("Enter deposit amount for account1: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" adding {0:C} to account1 balance\n", depositAmount);
            account1.Credit(depositAmount);

            // display balances
            Console.WriteLine("account1 balance {0:C}", account1.Balance);
            Console.WriteLine("account2 balance {0:C}", account2.Balance);

            // prompt
            Console.Write("Enter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(" adding {0:C} to account2 balance\n", depositAmount);
            account2.Credit(depositAmount);

            // display balances
            Console.WriteLine("account1 balance {0:C}", account1.Balance);
            Console.WriteLine("account2 balance {0:C}", account2.Balance);

        Console.ReadLine();
        }
    }

