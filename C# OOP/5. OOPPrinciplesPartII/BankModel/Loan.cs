/* Task 2
 * Loan Accounts can only deposit money.
 * Loan accounts have no interest for the first 3 months if are held by 
 * individuals and for the first 2 months if are held by a company. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Loan : Account, IDepositable
    {
        public Loan(Customer customer, decimal balance, int interest)
            : base(customer, balance, interest)
        {
            
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0;

            if (this.BankCustomer is Individual)
            {
                if (months < 3)
                {
                    interest = 0;
                }
                else
                {
                    months -= 3;
                    interest = this.Interest * months;
                }
            }
            else if (this.BankCustomer is Company)
            {
                if (months < 2)
                {
                    interest = 0;
                }
                else
                {
                    months -= 2;
                    interest = this.Interest * months;
                }
            }

            return interest;
        }
        
        public void DepositIn(decimal sum)
        {
            this.Balance += sum;
        }
    }
}
