﻿#region Usings

using System;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class StringExTest
    {
        [Test]
        public void CharAtArgumentNullExceptionTest()
        {
            String value = null;

            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => value.CharAt( 1 );
            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void CharAtArgumentOutOfRangeExceptionTest()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".CharAt( 0 );
            test.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void CharAtArgumentOutOfRangeExceptionTest1()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "test".CharAt( -1 );
            test.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void CharAtArgumentOutOfRangeExceptionTest2()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "test".CharAt( 4 );
            test.ShouldThrow<ArgumentOutOfRangeException>();
        }

        [Test]
        public void CharAtTest()
        {
            var actual = "test".CharAt( 0 );

            actual.Should()
                  .Be( 't' );
        }

        [Test]
        public void CharAtTest1()
        {
            var actual = "bar".CharAt( 1 );

            actual.Should()
                  .Be( 'a' );
        }

        [Test]
        public void CharAtTest2()
        {
            var actual = "bar".CharAt( 2 );

            actual.Should()
                  .Be( 'r' );
        }
    }
}