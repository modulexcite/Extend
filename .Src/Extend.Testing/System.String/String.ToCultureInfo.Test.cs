﻿#region Usings

using System;
using System.Globalization;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class StringExTest
    {
        [Test]
        public void ToCultureInfoTest()
        {
            const String culture = "en";
            var actual = culture.ToCultureInfo();

            Assert.AreEqual( culture, actual.Name );
        }

        [Test]
        public void ToCultureInfoTest1()
        {
            const String culture = "de-CH";
            var actual = culture.ToCultureInfo();

            Assert.AreEqual( culture, actual.Name );
        }

        [Test]
        public void ToCultureInfoTest1NullCheck()
        {
            const String culture = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => culture.ToCultureInfo();

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void ToCultureInfoTest2()
        {
            var culture = String.Empty;
            var actual = culture.ToCultureInfo();

            Assert.AreEqual( culture, actual.Name );
        }

        [Test]
        public void ToCultureInfoTest3()
        {
            const String culture = "invalidCultureName";
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => culture.ToCultureInfo();

            test.ShouldThrow<CultureNotFoundException>();
        }
    }
}