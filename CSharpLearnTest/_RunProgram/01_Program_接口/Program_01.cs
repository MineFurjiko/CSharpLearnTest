using CSharpLearnTest._Class._01_Class;
using CSharpLearnTest._Interface._01_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._RunProgram._01_Program_接口
{
    class Program_01
    {
        static void Main01(string[] args)
        {
            IBankAccount ccbAccount = new CCBAccount();
            ICBCAccount icbcAccount = new ICBCAccount();
            ITransferBankACcount abcAccount = new ABCAccount();

            ccbAccount.PayIn(200);
            ccbAccount.Withdraw(100);
            //ccbAccount.LookupTest();
            Console.WriteLine(ccbAccount.ToString());

            icbcAccount.PayIn(500);
            icbcAccount.Withdraw(600);
            icbcAccount.Withdraw(110);
            icbcAccount.LookupTest();
            Console.WriteLine(icbcAccount.ToString());

            abcAccount.PayIn(1000);
            Console.WriteLine(abcAccount.ToString());
            Console.WriteLine(icbcAccount.ToString());
            abcAccount.TransferTo(icbcAccount,250);
            Console.WriteLine(abcAccount.ToString());
            Console.WriteLine(icbcAccount.ToString());


        }
    }
}
