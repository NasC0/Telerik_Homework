/* Task 2
 * Withdrawable Interface which is required for the Deposit class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    interface IWithdrawable
    {
        void Withdraw(decimal sum);
    }
}
