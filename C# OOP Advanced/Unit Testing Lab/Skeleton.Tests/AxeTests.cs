using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void TestIfWeaponLosesDurabilityAfterAttack()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 10);

            var expectedResult = 9;
            axe.Attack(dummy);

            Assert.AreEqual(expectedResult, axe.DurabilityPoints);
        }

        [Test]
        public void TestAttackWithBrokenWeapon()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(10, 0);

            Assert.Throws(typeof(InvalidOperationException), () => axe.Attack(dummy));
        }
    }
}
