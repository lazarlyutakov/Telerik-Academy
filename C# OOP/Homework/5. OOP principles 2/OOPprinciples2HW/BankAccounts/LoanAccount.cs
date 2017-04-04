using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class LoanAccount : Accounts
    {
        public LoanAccount(Customer customer, decimal ballance, double interestRate, int monthsUsage) :
                                                  base(customer, ballance, interestRate, monthsUsage)
        {

        }

        public override void InterestAmount(uint numbOfMonths)
        {

            if(this.Customer.CustomerType == TypeOfCustomer.IndividualClient && numbOfMonths <= 3 ||
                this.Customer.CustomerType == TypeOfCustomer.CompanyClient && numbOfMonths <= 2)
            {
                Console.WriteLine("Interest amount of {0} is : 0", this.Customer.CustomerName);
            }
            else
            {
                Console.WriteLine("Interest amount of {0} is : {1}", this.Customer.CustomerName, this.InterestRate * numbOfMonths);
            }
        }
    }
}
