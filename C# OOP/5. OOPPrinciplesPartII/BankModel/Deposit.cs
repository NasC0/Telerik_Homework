/* Task 2
 * Deposit Accounts can both deposit and withdraw money.
 * Deposit accounts have no interest if their balance is positive and less than 1000. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, int interest)
            : base(customer, balance, interest)
        {
            
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0m;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }

        public void Withdraw(decimal sum)
        {
            this.Balance -= sum;
        }

        public void DepositIn(decimal sum)
        {
            this.Balance += sum;
        }
    }
}
