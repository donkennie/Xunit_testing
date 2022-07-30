using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Test.Applications.Calculations;
using Xunit;
using Xunit.Abstractions;

namespace Unit_Test.Tests.CalculationsTest
{

    public class CalculatorFixture
    {
        public Calculation Calc => new Calculation();
    }



    public class CalculationTest : IDisposable
    {

        private readonly ITestOutputHelper _testOutputHelper;
      //  private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;

        public CalculationTest(ITestOutputHelper testOutputHelper)//, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
          //  _calculatorFixture = calculatorFixture;
           _testOutputHelper.WriteLine("Constructor");

            memoryStream = new MemoryStream();
        }


        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckFiboIsNotZero()
        {
            _testOutputHelper.WriteLine("CheckFiboIsNotZero");

            var calc = new Calculation();

            Assert.DoesNotContain(0, calc.FiboNumbers);

            // Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void Check13Exist()
        {
            _testOutputHelper.WriteLine("Check13Exist");

            var calc = new Calculation();

            Assert.Contains(13, calc.FiboNumbers);

        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotInclude4()
        {
            var calc = new Calculation();

            Assert.DoesNotContain(4, calc.FiboNumbers);

        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void CheckFiboNumbers()
        {
            _testOutputHelper.WriteLine("CheckFiboNumbers.   Test starting at {0}",DateTime.Now);

            var allFiboNumbers = new List<int> { 1, 1, 2, 3, 5, 8, 13 };

            _testOutputHelper.WriteLine("Creating an instance of calculator class...");

            var calc = new Calculation();

            _testOutputHelper.WriteLine("Asserting...");

            Assert.Equal(allFiboNumbers, calc.FiboNumbers);

            _testOutputHelper.WriteLine("End...");

        }

        public void Dispose()
        {
            memoryStream.Close();

        }
    }
}
