using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Startup
    {
        static void Main(string[] args)
        {
            
           LoanAccount loan = new LoanAccount(new Customer(TypeOfCustomer.IndividualClient, "Pesho Goshev", 123963), 12500, 1, 2);
            DepositAccount deposit = new DepositAccount(new Customer(TypeOfCustomer.CompanyClient, "Boc-Boc OOD", 789369), 5000000, 5, 3);
            MortgageAccount mortgage = new MortgageAccount(new Customer(TypeOfCustomer.IndividualClient, "Gosho Peshev", 159357), 147258, 4, 8);


            loan.Deposit(100);
            Console.WriteLine("The ballance of {0} is : {1}", loan.Customer.CustomerName, loan.Ballance);
            Console.WriteLine("The customer ID of {0} is : {1}", deposit.Customer.CustomerName, deposit.Customer.customerID);
            Console.WriteLine("The ballance of {0} is : {1}", deposit.Customer.CustomerName, deposit.Ballance);
            deposit.Deposit(100000);
            Console.WriteLine("The ballance of {0} after deposit is : {1}", deposit.Customer.CustomerName, deposit.Ballance);
            mortgage.InterestAmount(3);
        }
    }
}
