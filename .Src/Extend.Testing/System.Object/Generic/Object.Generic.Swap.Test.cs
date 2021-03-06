﻿#region Usings

using System;
using System.Collections.Generic;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class ObjectExTest
    {
        [Test]
        public void SwapTest()
        {
            var value0 = new List<String>();
            var value1 = new List<String> { RandomValueEx.GetRandomString() };

            this.Swap( ref value0, ref value1 );
            Assert.AreEqual( 1, value0.Count );
            Assert.AreEqual( 0, value1.Count );
        }

        [Test]
        public void SwapTest1()
        {
            var value0 = 10;
            var value1 = 100;

            this.Swap( ref value0, ref value1 );
            Assert.AreEqual( 100, value0 );
            Assert.AreEqual( 10, value1 );
        }
    }
}