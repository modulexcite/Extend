﻿#region Usings

using System;
using System.Globalization;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class StringExTest
    {
        [Test]
        public void TryParsDateTimeTestCase()
        {
            var expected = DateTime.Now;
            var result = expected.Add( 1.ToDays() );
            var actual = expected.ToString( CultureInfo.InvariantCulture )
                                 .TryParsDateTime( out result );

            Assert.AreEqual( expected.Year, result.Year );
            Assert.AreEqual( expected.Month, result.Month );
            Assert.AreEqual( expected.Day, result.Day );
            Assert.AreEqual( expected.Hour, result.Hour );
            Assert.AreEqual( expected.Minute, result.Minute );
            Assert.AreEqual( expected.Second, result.Second );
            Assert.IsTrue( actual );
        }

        [Test]
        public void TryParsDateTimeTestCase1()
        {
            var expected = DateTime.Now;
            var result = expected.Add( 1.ToDays() );
            var actual = expected.ToString( CultureInfo.InvariantCulture )
                                 .TryParsDateTime( CultureInfo.InvariantCulture, DateTimeStyles.None, out result );

            Assert.AreEqual( expected.Year, result.Year );
            Assert.AreEqual( expected.Month, result.Month );
            Assert.AreEqual( expected.Day, result.Day );
            Assert.AreEqual( expected.Hour, result.Hour );
            Assert.AreEqual( expected.Minute, result.Minute );
            Assert.AreEqual( expected.Second, result.Second );
            Assert.IsTrue( actual );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void TryParsDateTimeTestCase1NullCheck()
        {
            var outValue = DateTime.Now;
            StringEx.TryParsDateTime( null, out outValue );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void TryParsDateTimeTestCase1NullCheck1()
        {
            var outValue = DateTime.Now;
            "".TryParsDateTime( null, DateTimeStyles.AllowInnerWhite, out outValue );
        }

        [Test]
        [ExpectedException( typeof (ArgumentNullException) )]
        public void TryParsDateTimeTestCaseNullCheck()
        {
            var outValue = DateTime.Now;
            StringEx.TryParsDateTime( null, out outValue );
        }
    }
}