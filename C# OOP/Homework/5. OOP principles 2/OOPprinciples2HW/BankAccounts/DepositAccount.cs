using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class DepositAccount : Accounts, IDeposit, IWithDraw
    {
        public DepositAccount(Customer customer, decimal ballance,  double interestRate, int monthsUsage) : 
                                                  base(customer, ballance, interestRate, monthsUsage)
        {

        }

        public void WithDrawMoney(decimal amount)
        {
            if(this.Ballance <= 0 || amount > this.Ballance)
            {
                throw new ArgumentException("Insufficient funds ! ");
            }

            this.ballance -= amount;
        }


        public override void InterestAmount(uint numberOfMonths)
        {
            if (this.Ballance < 1000)
            {
                Console.WriteLine("Interest amount of {0} is : 0", this.Customer.CustomerName);
            }
            else
            {
                Console.WriteLine("Interest amount of {0} is : {1}", this.Customer.CustomerName, this.InterestRate * numberOfMonths);
            }
        }
    }
}
