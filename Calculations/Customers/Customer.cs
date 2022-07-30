using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test.Applications.Customers
{
    public class Customer
    {
        public virtual int GetOrdersByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Kill");
            }

            return 100;
        }

        public int Age => 35;

        public string GetFullName(string firstname, string lastname)
        {
            return $"{firstname} {lastname}";
        }

    }


    public class LoyalCustomer : Customer
    {

        public int Discount { get; set; }


        public LoyalCustomer()
        {
            Discount = 10;
        }

        public override int GetOrdersByName(string name)
        {
            return 101;
        }

    }


    public static class CustomerFactory
    {
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount <= 100)
                return new Customer();

            else
                return new LoyalCustomer();
        }
    }
}
