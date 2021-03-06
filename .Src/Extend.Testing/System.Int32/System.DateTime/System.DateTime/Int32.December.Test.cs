﻿#region Usings

using System;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class Int32ExTest
    {
        [Test]
        public void DecemberTest()
        {
            var expected = new DateTime( 2000, 12, 10 );
            var actual = 10.December( 2000 );
            Assert.AreEqual( expected, actual );
        }
    }
}