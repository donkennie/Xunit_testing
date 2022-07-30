using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Test.Applications.Customers;
using Xunit;

namespace Unit_Test.Tests
{
    [Collection("Customer")]
   public class CustomerDetailsTest
    {

        private readonly CustomerFixture _customerFixture;

        public CustomerDetailsTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

        [Fact]
        public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
        {
            var customer = _customerFixture.Cust;

            Assert.Equal("Kenny", customer.GetFullName("Kennie", "T"));
        }
    }
}
