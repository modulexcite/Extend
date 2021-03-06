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
        public void EndOfMonthTest()
        {
            var dateTime = DateTime.Now;
            var expected = new DateTime( dateTime.Year, dateTime.Month, 1 ).AddMonths( 1 )
                                                                           .Subtract( 1.ToMilliseconds() );
            var actual = dateTime.EndOfMonth();
            Assert.AreEqual( expected, actual );
        }
    }
}