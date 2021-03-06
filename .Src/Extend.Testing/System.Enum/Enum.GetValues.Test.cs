﻿#region Usings

using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class EnumExTest
    {
        [Test]
        public void GetValuesTest()
        {
            var actual = EnumEx.GetValues<DayOfWeek>()
                               .ToList();
            Assert.AreEqual( 7, actual.Count );
            Assert.AreEqual( DayOfWeek.Sunday, actual[0] );
            Assert.AreEqual( DayOfWeek.Monday, actual[1] );
            Assert.AreEqual( DayOfWeek.Tuesday, actual[2] );
            Assert.AreEqual( DayOfWeek.Wednesday, actual[3] );
            Assert.AreEqual( DayOfWeek.Thursday, actual[4] );
            Assert.AreEqual( DayOfWeek.Friday, actual[5] );
            Assert.AreEqual( DayOfWeek.Saturday, actual[6] );
        }

        [Test]
        public void GetValuesTest1()
        {
            var type = typeof(DayOfWeek);
            var actual = EnumEx.GetValues( type );

            var casted = actual.Cast<Object>();
            var list = casted.Select( x => Convert.ChangeType( x, type ) )
                             .ToList();

            Assert.AreEqual( 7, list.Count );
            Assert.AreEqual( DayOfWeek.Sunday, list[0] );
            Assert.AreEqual( DayOfWeek.Monday, list[1] );
            Assert.AreEqual( DayOfWeek.Tuesday, list[2] );
            Assert.AreEqual( DayOfWeek.Wednesday, list[3] );
            Assert.AreEqual( DayOfWeek.Thursday, list[4] );
            Assert.AreEqual( DayOfWeek.Friday, list[5] );
            Assert.AreEqual( DayOfWeek.Saturday, list[6] );
        }

        [Test]
        public void GetValuesTestArgumentExceptionCheck()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => EnumEx.GetValues<Int32>();

            test.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void GetValuesTestArgumentExceptionCheck1()
        {
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => EnumEx.GetValues( typeof(Int32) );

            test.ShouldThrow<ArgumentException>();
        }

        [Test]
        public void GetValuesTestArgumentNullException()
        {
            Type t = null;
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => EnumEx.GetValues( t );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}