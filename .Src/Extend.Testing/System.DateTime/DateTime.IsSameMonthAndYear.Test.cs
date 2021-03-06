﻿#region Usings

using System;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class DateTimeExTest
    {
        [Test]
        public void IsSameMonthAndYearTest()
        {
            var dateTime = DateTime.Now;
            var otherDateTime = DateTime.Now;

            Assert.IsTrue( dateTime.IsSameMonthAndYear( otherDateTime ) );
        }

        [Test]
        public void IsSameMonthAndYearTest1()
        {
            var dateTime = new DateTime( 2014, 08, 10 );
            var otherDateTime = new DateTime( 2014, 08, 1 );

            Assert.IsTrue( dateTime.IsSameMonthAndYear( otherDateTime ) );
        }

        [Test]
        public void IsSameMonthAndYearTest2()
        {
            var dateTime = new DateTime( 2014, 08, 10 );
            var otherDateTime = new DateTime( 2014, 09, 1 );

            Assert.IsFalse( dateTime.IsSameMonthAndYear( otherDateTime ) );
        }

        [Test]
        public void IsSameMonthAndYearTest3()
        {
            var dateTime = new DateTime( 2014, 08, 10 );
            var otherDateTime = new DateTime( 2013, 08, 1 );

            Assert.IsFalse( dateTime.IsSameMonthAndYear( otherDateTime ) );
        }
    }
}