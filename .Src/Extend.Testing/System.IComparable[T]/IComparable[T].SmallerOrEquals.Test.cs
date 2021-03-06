﻿#region Usings

using System;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class ComparableTExTest
    {
        [Test]
        public void SmallerOrEqualsTest()
        {
            var value = 1000;
            var value1 = 900;

            var actual = value.SmallerOrEquals( value1 );
            Assert.IsFalse( actual );

            value = 10;
            value1 = 900;

            actual = value.SmallerOrEquals( value1 );
            Assert.IsTrue( actual );

            value = 10;
            value1 = 10;

            actual = value.SmallerOrEquals( value1 );
            Assert.IsTrue( actual );
        }

        [Test]
        public void SmallerOrEqualsTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => IComparableTEx.SmallerOrEquals( null, "" );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void SmallerOrEqualsTestNullCheck1()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => "".SmallerOrEquals( null );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}