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
        public void MarchTest()
        {
            var expected = new DateTime( 2000, 3, 10 );
            var actual = Int16Ex.March( 10, 2000 );
            Assert.AreEqual( expected, actual );
        }
    }
}