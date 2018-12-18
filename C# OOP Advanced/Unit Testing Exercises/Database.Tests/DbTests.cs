using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace Database.Tests
{
    [TestFixture]
    public class DbTests
    {
        private const int arrSize = 16;
        private const int initArrIndex = -1;
        Database database;
        Person person;

        [Test]
        public void EmptyConstructorShouldInitializeData()
        {
            database = new Database();

            var type = typeof(Database);

            var field = (int[])type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                 .First(f => f.Name == "data")
                 .GetValue(database);

            var lenght = field.Length;

            Assert.That(lenght, Is.EqualTo(arrSize), "Internal Array is null!");
        }

        [Test]
        public void EmptyConstructorShouldInitializeIndex()
        {
            database = new Database();

            var type = typeof(Database);

            var indexValue = (int)type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                 .First(f => f.Name == "index")
                 .GetValue(database);

            Assert.That(indexValue, Is.EqualTo(initArrIndex), "Index value is wrong!");
        }

        [Test]
        public void TestAddMethodForPeople()
        {
            database = new Database();
            person = new Person()
            {
                Id = 9407236258,
                Username = "Pesho123"
            };

            var expectedPerson = database.Add(person);
            var thisPerson = database.FindByUsername("Pesho123");

            Assert.AreSame(expectedPerson, thisPerson);
        }

        [Test]
        public void ThrowExceptionOnAddMethodIfPeopleAlreadyExist()
        {
            database = new Database();
            person = new Person()
            {
                Id = 9407236258,
                Username = "Pesho123"
            };

            var expectedPerson = database.Add(person);

            Assert.Throws(typeof(InvalidOperationException), () => database.Add(person));
        }

        [Test]
        public void TestForRemovingPeople()
        {
            database = new Database();
            person = new Person()
            {
                Id = 9407236258,
                Username = "Pesho123"
            };

            database.Add(person);

            Assert.AreSame(person, database.Remove(person));
        }

        [Test]
        public void TestForRemovingPeopleIfPeopleDoesNotExist()
        {
            database = new Database();
            person = new Person()
            {
                Id = 9407236258,
                Username = "Pesho123"
            };

            Assert.Throws(typeof(InvalidOperationException),() => database.Remove(person));
        }

        [Test]
        public void TestMethodFindPersonById()
        {
            database = new Database();
            person = new Person()
            {
                Id = 9407236258,
                Username = "Pesho123"
            };

            var currentPerson = database.Add(person);

            Assert.AreSame(currentPerson, database.FindById(9407236258));
        }

        [Test]
        public void TestMethodFindPersonByUsername()
        {
            database = new Database();
            person = new Person()
            {
                Id = 9407236258,
                Username = "Pesho123"
            };

            var currentPerson = database.Add(person);

            Assert.AreSame(currentPerson, database.FindByUsername("Pesho123"));
        }
    }
}
