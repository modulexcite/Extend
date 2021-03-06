﻿#region Usings

using System;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class DecimalExTest
    {
        [Test]
        public void PercentageOfTest()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 500;
            var actual = number.PercentageOf( 50 );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void PercentageOfTest1()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 500;
            var actual = number.PercentageOf( new Decimal( 50 ) );

            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void PercentageOfTest2()
        {
            var number = new Decimal( 1000 );
            const Int32 expected = 500;
            var actual = number.PercentageOf( (Int64) 50 );

            Assert.AreEqual( expected, actual );
        }
    }
}