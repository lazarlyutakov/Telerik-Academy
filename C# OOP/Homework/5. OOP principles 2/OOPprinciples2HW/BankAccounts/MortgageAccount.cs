using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class MortgageAccount : Accounts
    {
        public MortgageAccount(Customer customer, decimal ballance, double interestRate, int monthsUsage) :
                                                  base(customer, ballance, interestRate, monthsUsage)
        {

        }

        public override void InterestAmount(uint numbOfMonths)
        {
            if(this.Customer.CustomerType == TypeOfCustomer.CompanyClient && numbOfMonths <= 12)
            {
                Console.WriteLine("Interest amount is of {0} : {1}", this.Customer.CustomerName, (this.InterestRate * numbOfMonths) / 2);
            }
            else if(this.Customer.CustomerType == TypeOfCustomer.IndividualClient && numbOfMonths <= 6)
            {
                Console.WriteLine("Interest amount is of {0} : 0", this.Customer.CustomerName);
            }
            else
            {
                Console.WriteLine("Interest amount of {0} is : {1}", this.Customer.CustomerName, this.InterestRate * numbOfMonths);
            }
        }
    }
}
