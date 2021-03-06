﻿#region Usings

using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class Int32ExTest
    {
        [Test]
        public void IsOddTest()
        {
            var value = RandomValueEx.GetRandomInt32();

            var expected = value % 2 != 0;
            var actual = value.IsOdd();
            Assert.AreEqual( expected, actual );
        }
    }
}