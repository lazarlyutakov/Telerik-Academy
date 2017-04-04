using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class Customer
    {
        protected TypeOfCustomer customerType;
        protected string customerName;
        public uint customerID;


        public Customer(TypeOfCustomer customerType, string customerName, uint customerID)
        {
            this.CustomerType = customerType;
            this.CustomerName = customerName;
            this.CustomerID = customerID;
        }


        public TypeOfCustomer CustomerType { get; private set; }

        public string CustomerName
        {
            get { return this.customerName; }

            private set
            {
                if(value == string.Empty)
                {
                    throw new ArgumentNullException("Please, enter customer's name ! ");
                }
                this.customerName = value;
            }
        }

        public uint CustomerID
        {
            get { return this.customerID; }

            private set
            {
                if (value == default(int))
                {
                    throw new ArgumentNullException("Please, enter customer's ID ! ");
                }
                else if(value < 100000 || value > 999999)
                {
                    throw new IndexOutOfRangeException("Customer's ID must be a 6 digit number ! ");
                }
                this.customerID = value;
            }
        }
    }
}
