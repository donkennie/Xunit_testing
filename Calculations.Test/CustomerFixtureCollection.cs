﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Unit_Test.Tests
{
    [CollectionDefinition("Customer")]
    public class CustomerFixtureCollection : ICollectionFixture<CustomerFixture>
    {
    }
}
