﻿#region Usings

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class DateTimeExTest
    {
        [Test]
        public void ToMonthDayStringTest()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "m" );
            var actual = dateTime.ToMonthDayString();
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void ToMonthDayStringTest1()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "m", DateTimeFormatInfo.CurrentInfo );
            // ReSharper disable once AssignNullToNotNullAttribute
            var actual = dateTime.ToMonthDayString( DateTimeFormatInfo.CurrentInfo );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void ToMonthDayStringTest2()
        {
            var dateTime = DateTime.Now;
            var expected = dateTime.ToString( "m", CultureInfo.InvariantCulture );
            var actual = dateTime.ToMonthDayString( CultureInfo.InvariantCulture );
            Assert.AreEqual( expected, actual );
        }
    }
}