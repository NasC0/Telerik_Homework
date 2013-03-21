/* Task 2
 * Depositable Interface which is required for the Loan, Deposit and Mortgage classes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    interface IDepositable
    {
        void DepositIn(decimal sum);
    }
}
