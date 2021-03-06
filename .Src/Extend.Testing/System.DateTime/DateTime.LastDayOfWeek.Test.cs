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
        public void LastDayOfWeekTest()
        {
            var dateTime = new DateTime( 2014, 3, 30 );
            var actual = dateTime.LastDayOfWeek();

            Assert.AreEqual( dateTime, actual );

            dateTime = new DateTime( 2014, 3, 28 );
            actual = dateTime.LastDayOfWeek();

            Assert.AreEqual( new DateTime( 2014, 3, 30 ), actual );
        }
    }
}