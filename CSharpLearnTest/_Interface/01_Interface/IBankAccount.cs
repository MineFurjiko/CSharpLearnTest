using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Interface._01_Interface
{
    interface IBankAccount
    {
        decimal Balance { get; }
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
    }
}
