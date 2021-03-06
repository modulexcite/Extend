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
    public partial class IDictionaryExTest
    {
        [Test]
        public void StringJoinTest()
        {
            var dictionary = new Dictionary<String, String>
            {
                { RandomValueEx.GetRandomString(), RandomValueEx.GetRandomString() },
                { RandomValueEx.GetRandomString(), RandomValueEx.GetRandomString() }
            };

            var actual = dictionary.StringJoin();
            var expected = "{0}={1}{2}={3}".F( dictionary.First()
                                                         .Key,
                                               dictionary.First()
                                                         .Value,
                                               dictionary.Last()
                                                         .Key,
                                               dictionary.Last()
                                                         .Value );
            Assert.AreEqual( expected, actual );

            actual = dictionary.StringJoin( ",", ";" );
            expected = "{0},{1};{2},{3}".F( dictionary.First()
                                                      .Key,
                                            dictionary.First()
                                                      .Value,
                                            dictionary.Last()
                                                      .Key,
                                            dictionary.Last()
                                                      .Value );
            Assert.AreEqual( expected, actual );
        }

        [Test]
        public void StringJoinTestNullCheck()
        {
            Dictionary<String, String> dictionary = null;
            // ReSharper disable once AssignNullToNotNullAttribute
            // ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            Action test = () => dictionary.StringJoin( "" );

            test.ShouldThrow<ArgumentNullException>();
        }
    }
}