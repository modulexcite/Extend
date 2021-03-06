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
        public void OctoberTest()
        {
            var expected = new DateTime( 2000, 10, 10 );
            var actual = 10.October( 2000 );
            Assert.AreEqual( expected, actual );
        }
    }
}