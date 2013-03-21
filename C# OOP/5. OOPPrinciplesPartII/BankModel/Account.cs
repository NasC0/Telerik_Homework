/* Task 2
 * Abstract Account class that serves as a base class for Loan, Deposit and Mortgage classes
 * All accounts have customer, balance and interest rate (monthly based).
 * All accounts can calculate their interest amount for a given period (in months). 
 * In the common case its is calculated as follows: number_of_months * interest_rate. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public abstract class Account
    {
        public Customer BankCustomer { get; protected set; }
        public decimal Balance { get; protected set; }
        public int Interest { get; protected set; }

        public Account(Customer customer, decimal balance, int interest)
        {
            this.BankCustomer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal interest = months * this.Interest;
            return interest;
        }
    }
}
