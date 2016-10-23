// Crate and manipulate Account objects

using System;

namespace AccountTest
{


    public class AccountTest
    {
        public static void Main(String[] args)
        {
            Account account1 = new Account(50.00M);
            Account account2 = new Account(-7.53M);

            // display initial balance of each object using a property
            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}", account2.Balance);
            account1.Credit(depositAmount);

            // prompt and obtain user input
            Console.Write("Enter deposit amount for account1: ");
            depositamount = Convet.ToDecimal(Console.ReadLine());
            Console.WriteLine(" adding {0:C} to account1 balance\n", depositamount);

            // display balances
            Console.WriteLine("account1 balance: {0:C}", account1.Balance);
            Console.WriteLine("account2 balance: {0:C}\n", account2.Balance);


            // prompt and obtain user input
            Console.Write(" Enter deposit amount for account2: ");
            depositAmount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("adding {0:C} to account2 balance \n", depositAmount);
            account2.Credit(depositAmount);

            // display balances
            Console.WriteLine(" account1 balance: {0:C}", account1.Balance);
            Console.WriteLine(" account2 balance: {0:C}", account2.Balance);

        }
    }
}
