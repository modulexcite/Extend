﻿#region Usings

using System;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class Int64ExTest
    {
        [Test]
        public void IsMultipleFactorOf0Test()
        {
            const Int64 value = 10;
            const Int64 factor = 0;

            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => value.IsMultipleOf( factor );
            test.ShouldThrow<DivideByZeroException>();
        }

        [Test]
        public void IsMultipleOfTest()
        {
            Int64 value = RandomValueEx.GetRandomInt32();
            Int64 factor = RandomValueEx.GetRandomInt32();

            var expected = value % factor == 0;
            var actual = value.IsMultipleOf( factor );
            Assert.AreEqual( expected, actual );

            value = 10;
            factor = 2;

            actual = value.IsMultipleOf( factor );
            Assert.AreEqual( true, actual );

            value = 10;
            factor = 3;

            actual = value.IsMultipleOf( factor );
            Assert.AreEqual( false, actual );
        }

        [Test]
        public void IsMultipleValueOf0Test()
        {
            const Int64 value = 0;
            const Int64 factor = 10;

            var actual = value.IsMultipleOf( factor );
            actual.Should()
                  .BeFalse();
        }
    }
}