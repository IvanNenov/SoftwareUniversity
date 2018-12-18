using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Skeleton.Tests
{
    [TestFixture]
    class DummyTests
    {
        Dummy dummy;
        [Test]
        public void DummyLosesHealtIfArracked()
        {
            dummy = new Dummy(10, 10);
            dummy.TakeAttack(9);

            var expectedResult = 1;
            Assert.AreEqual(expectedResult, dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            dummy = new Dummy(0, 10);

            Assert.Throws(typeof(InvalidOperationException), () => dummy.TakeAttack(10));
        }

        [Test]
        public void DeadDummyCanGiveXP()
        {
            dummy = new Dummy(0, 10);

            var expectedResult = 10;

            Assert.AreEqual(expectedResult, dummy.GiveExperience());
        }

        [Test]
        public void AliveDummyCantGiveXP()
        {
            dummy = new Dummy(10, 10);

            Assert.Throws(typeof(InvalidOperationException), () => dummy.GiveExperience());
        }
    }
}
