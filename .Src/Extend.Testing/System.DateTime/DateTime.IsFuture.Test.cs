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
        public void IsFutureTest()
        {
            var dateTime = DateTime.Now.Subtract( 1.ToMilliseconds() );
            var actual = dateTime.IsFuture();
            Assert.IsFalse( actual );

            dateTime = DateTime.Now.AddDays( 2 );
            actual = dateTime.IsFuture();
            Assert.IsTrue( actual );
        }
    }
}