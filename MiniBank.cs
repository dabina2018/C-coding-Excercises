using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a 'Bank Account'  //
            // 10digit number, name of owners, account balance, accept deposit and withdrawl
            //initial balance should be positive(+)          //able  to show negative balance

            var account = new BankAccount("Billy Bob", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            //making a withdrawal
            account.MakeWithdrawl(120, DateTime.Now, "Hammock");
            //Console.WriteLine(account.Balance);

            account.MakeWithdrawl(50, DateTime.Now, "XBox Game");
            //Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());


            //// test error handling for (-) balance
            //account.MakeWithdrawl(75000, DateTime.Now, "Barbie Dream House");
            ////Console.WriteLine(account.Balance);

            ////attempt to make a negative(-) deposit to test error handling
            //account.MakeDeposit(-300, DateTime.Now, "stealing");

            ////test that initial balance must be positive
            //try
            //{
            //    var invalidAccount = new BankAccount("invalid", -55);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    //Console.WriteLine("Exception caught creating account with negative balance");
            //    //Console.WriteLine(e.ToString());
            //}
            

        }
    }
}
