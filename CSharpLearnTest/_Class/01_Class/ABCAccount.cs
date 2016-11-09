using CSharpLearnTest._Interface._01_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpLearnTest._Class._01_Class
{
    class ABCAccount : ITransferBankACcount
    {

        public bool TransferTo(IBankAccount account, decimal amount)
        {
            bool result;
            result = Withdraw(amount);
            if (result)
            {
                account.PayIn(amount);
            }
            return result;
        }

        private decimal balance;

        public decimal Balance
        {
            get { return this.balance; }
        }

        public void PayIn(decimal amount)
        {
            this.balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (this.balance >= amount)
            {
                this.balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawal attempt failed!");
            return false;
        }

        public override string ToString()
        {
            return string.Format("ABC Saver:Balance={0,6:c}", balance);
        }

        public void LookupTest()
        { }
    }
}
