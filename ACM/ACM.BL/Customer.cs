using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string FullName
        {
            get
            {
                return LastName +
                    (string.IsNullOrWhiteSpace(LastName) ? "" :
                    string.IsNullOrWhiteSpace(FirstName) ? "" : ", ")
                    + FirstName;
            }
        }

        public static int IntanceCount { get; set; } = 0;

        public bool Validate()
        {
            return !string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(EMail);
        }

        public bool Save()
        {
            return false;
        }

        public Customer Retrive(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrive()
        {
            return new List<Customer>();
        }
    }
}
