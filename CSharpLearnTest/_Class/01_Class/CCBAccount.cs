using CSharpLearnTest._Interface._01_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Class._01_Class
{
    class CCBAccount:IBankAccount
    {
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
            if (this.balance>=amount)
            {
                this.balance -= amount;
                return true;
            }
            Console.WriteLine("Withdrawal attempt failed!");
            return false;
        }

        public override string ToString()
        {
            return string.Format("CCB Saver:Balance={0,6:c}",balance);
        }

        public void LookupTest()
        { }
    }
}
