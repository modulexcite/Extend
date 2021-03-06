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
        public void SplitTest()
        {
            var actual = "1,2,3".Split( "," );
            Assert.AreEqual( 3, actual.Length );
            Assert.AreEqual( "1", actual[0] );
            Assert.AreEqual( "2", actual[1] );
            Assert.AreEqual( "3", actual[2] );
        }

        [Test]
        public void SplitTest1()
        {
            var actual = "1,2,,3.4".Split( StringSplitOptions.RemoveEmptyEntries, ",", "." );
            Assert.AreEqual( 4, actual.Length );
            Assert.AreEqual( "1", actual[0] );
            Assert.AreEqual( "2", actual[1] );
            Assert.AreEqual( "3", actual[2] );
            Assert.AreEqual( "4", actual[3] );
        }

        [Test]
        public void SplitTest1NullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => StringEx.Split( null, StringSplitOptions.RemoveEmptyEntries, "" );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void SplitTest1NullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => "".Split( StringSplitOptions.RemoveEmptyEntries, null );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void SplitTestNullCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => StringEx.Split( null, "" );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void SplitTestNullCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => StringEx.Split( "", null );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}