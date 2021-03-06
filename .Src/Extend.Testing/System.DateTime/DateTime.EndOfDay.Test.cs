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
        public void EndOfDayTest()
        {
            var dateTime = DateTime.Now;
            var expected =
                new DateTime( dateTime.Year, dateTime.Month, dateTime.Day ).AddDays( 1 )
                                                                           .Subtract( 1.ToMilliseconds() );
            var actual = dateTime.EndOfDay();
            Assert.AreEqual( expected, actual );
        }
    }
}