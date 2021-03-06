﻿#region Usings

using System.Linq;
using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class CharExTest
    {
        [Test]
        public void IsLetterTest()
        {
            var range = 0.RangeTo( 9 );
            foreach ( var c in range.Select( x => x.ToChar() ) )
                Assert.IsFalse( c.IsLetter() );

            Assert.IsTrue( 'a'.IsLetter() );
            Assert.IsTrue( 'A'.IsLetter() );
            Assert.IsTrue( 'z'.IsLetter() );
            Assert.IsFalse( '-'.IsLetter() );
        }
    }
}