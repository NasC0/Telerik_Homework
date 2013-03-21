/* Task 2
 * Mortgage Accounts can only deposit money.
 * Mortgage accounts have ½ interest for the first 12 months 
 * for companies and no interest for the first 6 months for individuals. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class Mortgage : Account, IDepositable
    {
        public Mortgage(Customer customer, decimal balance, int interest)
            : base(customer, balance, interest)
        {
            
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest = 0;

            if (this.BankCustomer is Individual)
            {
                if (months <= 6)
                {
                    interest = 0;
                }
                else
                {
                    months -= 6;
                    interest = this.Interest * months;
                }
            }
            else if (this.BankCustomer is Company)
            {
                if (months <= 12)
                {
                    interest = (this.Interest * months) / 2;
                }
                else
                {
                    interest = (this.Interest * 12) / 2;
                    months -= 12;
                    interest += this.Interest * months;
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
