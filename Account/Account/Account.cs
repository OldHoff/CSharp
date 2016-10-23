using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Account
{
    private decimal balance;

    // constructor
    public Account( decimal initialBalance )
    {
        balance = initialBalance;
    }

    public void Credit( decimal amount )
    {
        balance = balance + amount;
    }

    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            // validate that value is grater than or equal to 0;
            // if it is not, balance is left unchanged
            if (value >= 0)
                balance = value;
        }
    }
}