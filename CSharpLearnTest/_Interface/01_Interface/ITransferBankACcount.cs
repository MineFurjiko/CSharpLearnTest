using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearnTest._Interface._01_Interface
{
    interface ITransferBankACcount:IBankAccount
    {
        bool TransferTo(IBankAccount account,decimal amount);
    }
}
