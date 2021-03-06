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
        public void ExtractAllInt16Test()
        {
            const Int32 value0 = 100;
            const Int32 value1 = 102;
            const Int32 value2 = -1100;
            const Int32 value3 = 12300;

            var stringValue = "".ConcatAll( value0, "asdasd.)(/)(=+", value1, "a", value2, "asd", value3 );
            var actual = stringValue.ExtractAllInt16();

            Assert.AreEqual( 4, actual.Count );
            Assert.AreEqual( value0, actual[0] );
            Assert.AreEqual( value1, actual[1] );
            Assert.AreEqual( value2, actual[2] );
            Assert.AreEqual( value3, actual[3] );

            actual = "10.10".ExtractAllInt16();
            Assert.AreEqual( 2, actual.Count );
            Assert.AreEqual( 10, actual[0] );
            Assert.AreEqual( 10, actual[1] );
        }

        [Test]
        public void ExtractAllInt16TestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => StringEx.ExtractAllInt16( null );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void ExtractAllInt16TestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => StringEx.ExtractAllInt16( null, 10 );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}