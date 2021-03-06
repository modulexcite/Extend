﻿#region Usings

using NUnit.Framework;

#endregion

namespace Extend.Testing
{
    [TestFixture]
    public partial class Int16ExTest
    {
        [Test]
        public void FactorOfTest()
        {
            var value = RandomValueEx.GetRandomInt16();
            var factorNumer = RandomValueEx.GetRandomInt16();

            var expected = factorNumer % value == 0;
            var actual = value.FactorOf( factorNumer );
            Assert.AreEqual( expected, actual );

            value = 10;
            factorNumer = 100;
            expected = true;
            actual = value.FactorOf( factorNumer );
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.AreEqual( expected, actual );

            value = 11;
            factorNumer = 100;
            expected = false;
            actual = value.FactorOf( factorNumer );
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.AreEqual( expected, actual );
        }
    }
}