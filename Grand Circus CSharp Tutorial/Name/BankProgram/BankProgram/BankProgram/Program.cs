using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram
{
    class BankProgram
    {
        //structure
        enum accountState
        {
            New,
            Active,
            UnderAudit,
            Frozen,
            Closed
        };


        struct Account
        {
            public string Name;
            public string Address;
            public int AccountNumber;
            public int Balance;
            public int Overdraft;

        };
        //program
        static void Main(string[] args)
        {
            Account ZAccount;
                ZAccount.Name = "ZMillionz";
                ZAccount.Address = "Z Millions Place";
                ZAccount.AccountNumber = 99999999;
                ZAccount.Balance = 99999999;
                ZAccount.Overdraft = -1000;
                Console.WriteLine("Name is :" + ZAccount.Name);
                Console.WriteLine("Balance is :" + ZAccount.Balance);



                Console.ReadKey();
        }
    }
}
