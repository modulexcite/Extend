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
        public void ToMillisecondsTest()
        {
            var value = RandomValueEx.GetRandomInt32( 1, 100 );

            var expected = TimeSpan.FromMilliseconds( value );
            var actual = ( (Int64) value ).ToMilliseconds();

            actual
                .Should()
                .Be( expected );
        }

        [Test]
        public void ToMillisecondsTooLargeTest()
        {
            const Int64 value = Int64.MaxValue;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => value.ToMilliseconds();

            test.ShouldThrow<OverflowException>();
        }

        [Test]
        public void ToMillisecondsTooSmallTest()
        {
            const Int64 value = Int64.MinValue;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => value.ToMilliseconds();

            test.ShouldThrow<OverflowException>();
        }
    }
}