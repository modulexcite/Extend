﻿#region Usings

using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class StringExTest
    {
        [Test]
        public void IfEmptyTest()
        {
            var actual = StringEx.IfNotEmpty( null, "test" );
            Assert.AreEqual( "test", actual );

            actual = "".IfNotEmpty( "test" );
            Assert.AreEqual( "test", actual );

            actual = "   ".IfNotEmpty( "test" );
            Assert.AreEqual( "test", actual );

            actual = "abc".IfNotEmpty( "test" );
            Assert.AreEqual( "abc", actual );
        }
    }
}