﻿#region Usings

using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public class XOrSpecificationTest
    {
        [Test]
        public void AndTest()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => true );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.And( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void AndTest1()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => true );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.And( new ExpressionSpecification<String>( x => false ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void AndTest2()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.And( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsTrue( result );
        }

        [Test]
        public void AndTest3()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.And( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void AndTest4()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.And( new ExpressionSpecification<String>( x => false ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void AndTestNullCheck()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            ExpressionSpecification<String> other = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => target.And( other );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void CtorTestNulLCheck()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ObjectCreationAsStatement
            Action test = () => new XOrSpecification<String>( new ExpressionSpecification<String>( x => true ), null );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void CtorTestNulLCheck1()
        {
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ObjectCreationAsStatement
            Action test = () => new XOrSpecification<String>( null, new ExpressionSpecification<String>( x => true ) );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void IsSatisfiedByTest()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => true );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( actaul );
        }

        [Test]
        public void IsSatisfiedByTest1()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => true );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedBy( String.Empty );
            Assert.IsTrue( actaul );
        }

        [Test]
        public void IsSatisfiedByTest2()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => false );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedBy( String.Empty );
            Assert.IsTrue( actaul );
        }

        [Test]
        public void IsSatisfiedByTest3()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( actaul );
        }

        [Test]
        public void IsSatisfiedByWithMessagesTest()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => true );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedByWithMessages( String.Empty )
                               .ToList();
            Assert.AreEqual( 1, actaul.Count );
            Assert.AreEqual( actaul[0], "The given object matches both specifications." );
        }

        [Test]
        public void IsSatisfiedByWithMessagesTest1()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => true );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedByWithMessages( String.Empty )
                               .ToList();
            Assert.AreEqual( 0, actaul.Count );
        }

        [Test]
        public void IsSatisfiedByWithMessagesTest2()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => false );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedByWithMessages( String.Empty )
                               .ToList();
            Assert.AreEqual( 0, actaul.Count );
        }

        [Test]
        public void IsSatisfiedByWithMessagesTest3()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedByWithMessages( String.Empty )
                               .ToList();
            Assert.AreEqual( 2, actaul.Count );
            Assert.IsNull( actaul[0] );
            Assert.IsNull( actaul[1] );
        }

        [Test]
        public void IsSatisfiedByWithMessagesTest4()
        {
            var left = new ExpressionSpecification<String>( x => true, "msgLeft" );
            var right = new ExpressionSpecification<String>( x => true, "msgRight" );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedByWithMessages( String.Empty )
                               .ToList();
            Assert.AreEqual( 1, actaul.Count );
            Assert.AreEqual( actaul[0], "The given object matches both specifications." );
        }

        [Test]
        public void IsSatisfiedByWithMessagesTest5()
        {
            var left = new ExpressionSpecification<String>( x => false, "msgLeft" );
            var right = new ExpressionSpecification<String>( x => true, "msgRight" );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedByWithMessages( String.Empty )
                               .ToList();
            Assert.AreEqual( 0, actaul.Count );
        }

        [Test]
        public void IsSatisfiedByWithMessagesTest6()
        {
            var left = new ExpressionSpecification<String>( x => true, "msgLeft" );
            var right = new ExpressionSpecification<String>( x => false, "msgRight" );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedByWithMessages( String.Empty )
                               .ToList();
            Assert.AreEqual( 0, actaul.Count );
        }

        [Test]
        public void IsSatisfiedByWithMessagesTest7()
        {
            var left = new ExpressionSpecification<String>( x => false, "msgLeft" );
            var right = new ExpressionSpecification<String>( x => false, "msgRight" );

            var target = new XOrSpecification<String>( left, right );
            var actaul = target.IsSatisfiedByWithMessages( String.Empty )
                               .ToList();
            Assert.AreEqual( 2, actaul.Count );
            Assert.AreEqual( 1, actaul.Count( x => x == "msgLeft" ) );
            Assert.AreEqual( 1, actaul.Count( x => x == "msgRight" ) );
        }

        [Test]
        public void OrTest()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => true );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.Or( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsTrue( result );
        }

        [Test]
        public void OrTest1()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => true );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.Or( new ExpressionSpecification<String>( x => false ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void OrTest2()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.Or( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsTrue( result );
        }

        [Test]
        public void OrTest3()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.Or( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsTrue( result );
        }

        [Test]
        public void OrTest4()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.Or( new ExpressionSpecification<String>( x => false ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void OrTestNullCheck()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            ExpressionSpecification<String> other = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => target.Or( other );

            test.ShouldThrow<ArgumentNullException>();
        }

        [Test]
        public void XOrTest()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => true );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.XOr( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsTrue( result );
        }

        [Test]
        public void XOrTest1()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => true );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.XOr( new ExpressionSpecification<String>( x => false ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void XOrTest2()
        {
            var left = new ExpressionSpecification<String>( x => true );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.XOr( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void XOrTest3()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.XOr( new ExpressionSpecification<String>( x => true ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsTrue( result );
        }

        [Test]
        public void XOrTest4()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            var actual = target.XOr( new ExpressionSpecification<String>( x => false ) );
            var result = actual.IsSatisfiedBy( String.Empty );
            Assert.IsFalse( result );
        }

        [Test]
        public void XOrTestNullCheck()
        {
            var left = new ExpressionSpecification<String>( x => false );
            var right = new ExpressionSpecification<String>( x => false );
            var target = new XOrSpecification<String>( left, right );

            ExpressionSpecification<String> other = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            Action test = () => target.XOr( other );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}