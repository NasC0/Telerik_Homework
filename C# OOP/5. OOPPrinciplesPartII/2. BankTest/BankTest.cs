/* Task 2
 * Your task is to write a program to model the bank system by classes and interfaces. 
 * You should identify the classes, interfaces, base classes and abstract actions and 
 * implement the calculation of the interest functionality through overridden methods. */

using System;
using System.Collections.Generic;
using System.Linq;
using BankModel;

class BankTest
{
    static void Main()
    {
        Deposit deposit = new Deposit(new Individual("Phili Fry"), 5000m, 5);
        deposit.DepositIn(1000m);
        Console.WriteLine(deposit.Balance);
        deposit.Withdraw(1500m);
        Console.WriteLine(deposit.Balance);
        Console.WriteLine(deposit.CalculateInterest(5));

        Console.WriteLine("-------------------");

        Loan loan = new Loan(new Individual("James"), 2000m, 20);
        loan.DepositIn(2000m);
        Console.WriteLine(loan.Balance);
        Console.WriteLine(loan.CalculateInterest(5));

        Console.WriteLine("-------------------");

        Loan companyLoan = new Loan(new Company("Telecom"), 2000m, 20);
        companyLoan.DepositIn(3000m);
        Console.WriteLine(companyLoan.Balance);
        Console.WriteLine(companyLoan.CalculateInterest(5));

        Console.WriteLine("-------------------");

        Mortgage mortgage = new Mortgage(new Individual("Bart"), 2000m, 20);
        mortgage.DepositIn(3000m);
        Console.WriteLine(mortgage.Balance);
        Console.WriteLine(mortgage.CalculateInterest(8));

        Console.WriteLine("-------------------");

        Mortgage companyMortgate = new Mortgage(new Company("Airline"), 2000m, 20);
        Console.WriteLine(companyMortgate.CalculateInterest(16));
    }
}
