﻿#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    // ReSharper disable once InconsistentNaming
    public partial class IEnumerableTExTest
    {
        [Test]
        public void RandomizeTest()
        {
            var list = new List<String>();
            var result = list.Randomize();
            Assert.AreEqual( list.Count, result.Count() );

            list = RandomValueEx.GetRandomStrings( 100 );
            result = list.Randomize();
            // ReSharper disable once PossibleMultipleEnumeration
            Assert.AreEqual( list.Count, result.Count() );
            // ReSharper disable once PossibleMultipleEnumeration
            Assert.IsTrue( list.All( x => result.Contains( x ) ) );

            // ReSharper disable once PossibleMultipleEnumeration
            var resultList = result.ToList();
            if ( list.Where( ( t, i ) => t != resultList[i] )
                     .Any() )
                return;
            Assert.IsTrue( false, "The items are in the same order in both collections." );
        }

        [Test]
        public void RandomizeTestNullCheck()
        {
            List<Object> list = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => list.Randomize();

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}