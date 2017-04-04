using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Accounts : IDeposit
    {
        protected Customer customer;
        protected decimal ballance;
        protected double interestRate;
        protected int monthsUsage;


        public Accounts(Customer customer, decimal ballance, double interestRate, int monthsUsage)
        {
            this.Customer = customer;
            this.Ballance = ballance;
            this.InterestRate = interestRate;
            this.MonthsUsage = monthsUsage;
        }



        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            private set
            {
            
                this.customer = value;
            }
        }

        public decimal Ballance
        {
            get
            {
                return this.ballance; 
            }
            private set
            {
            
                this.ballance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            private set
            {
           
                this.interestRate = value;
            }
        }

        public int MonthsUsage
        {
            get
            {
                return this.monthsUsage;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of months must be > 0 !");
                }
                this.monthsUsage = value;
            }
        }


        public void Deposit(decimal ammount)
        {
            if(ammount < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit must be > 0 !");
            }

            this.Ballance += ammount;
        }


        public virtual void InterestAmount(uint numbOfMonths)
        {
            
        }
    }
}
