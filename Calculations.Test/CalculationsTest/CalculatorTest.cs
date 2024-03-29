﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Test.Applications.Calculations;
using Xunit;

namespace Unit_Test.Tests.Calculations.Test
{
    public class CalculatorTest
    {

        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();

            var result = calc.Add(1, 2);

            Assert.Equal(3, result);
        }


        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();

            var result = calc.AddDouble(1.2, 3.2);

            Assert.Equal(4.4, result);
        }
    }
}
