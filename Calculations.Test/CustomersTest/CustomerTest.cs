using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Test.Applications.Customers;
using Xunit;

namespace Unit_Test.Tests.CustomersTest
{

    [Collection("Customer")]
    public class CustomerTest
    {

        private readonly CustomerFixture _customerFixture;

        public CustomerTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = _customerFixture.Cust;

            Assert.InRange(customer.Age, 25, 40);

        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = _customerFixture.Cust;

            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));

            Assert.Equal("Kill", exceptionDetails.Message);
        }


        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);

            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);

            Assert.Equal(10, loyalCustomer.Discount);
        }


        }
}
