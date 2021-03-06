﻿#region Usings

using System;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class Int16ExTest
    {
        [Test]
        public void DecemberTest()
        {
            var expected = new DateTime( 2000, 12, 10 );
            var actual = Int16Ex.December( 10, 2000 );
            Assert.AreEqual( expected, actual );
        }
    }
}