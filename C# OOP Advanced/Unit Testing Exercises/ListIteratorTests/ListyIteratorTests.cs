using ListIterator;
using NUnit.Framework;
using System;

namespace ListIteratorTests
{
    [TestFixture]
    public class ListyIteratorTests
    {
        private string[] input = new string[] { "a", "b", "c" };
        private ListyIterator<string> list;

        [SetUp]
        public void TestUnit()
        {
            list = new ListyIterator<string>(input);
        }

        [Test]
        public void MoveWithNextElementShouldReturnTrue()
        {
            Assert.That(() => list.Move(), Is.True);
        }

        [Test]
        public void MoveWithNoNextEelementShoudReturnFalse()
        {
            list.Move();
            list.Move();

            Assert.That(() => list.Move(), Is.False);
        }

        [Test]
        public void HasNextShouldReturnTrueIfHasNext()
        {
            Assert.That(() => list.HasNext(), Is.True);
        }

        [Test]
        public void HasNextNoNextElementShouldReturnFalse()
        {
            list.Move();
            list.Move();

            Assert.That(() => list.HasNext(), Is.False);
        }

        [Test]
        public void PrintEmptyListThrows()
        {
            list = new ListyIterator<string>();

            Assert.That(() => list.Print(), Throws.InvalidOperationException);
        }
    }
}
