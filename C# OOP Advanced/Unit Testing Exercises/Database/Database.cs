using System;
using System.Collections.Generic;
using System.Linq;

namespace Database
{
    public class Database
    {
        private const int Capacity = 16;
        private int[] data;
        private int index;
        private List<Person> people;

        public Database()
        {
            this.data = new int[Capacity];
            this.index = -1;
            this.people = new List<Person>();
        }

        public Database(int[] values)
            :this()
        {
            if (values.Length > 16)
            {
                throw new InvalidOperationException("Parameter is too long!");
            }

            for (int i = 0; i < values.Length; i++)
            {
                this.data[i] = values[i];
            }

            this.index = values.Length -1;
            this.people = new List<Person>();
        }

        public void Add(int value)
        {
            if (this.index < Capacity)
            {
                this.data[++this.index] = value;
                return;
            }

            throw new InvalidOperationException("Database is full!");
        }

        public void Remove()
        {
            if (this.index == 0)
            {
                throw new InvalidOperationException("Database is empty!");
            }

            this.data[this.index] = 0;
            this.index--;
        }

        public int[] Fetch()
        {
            return this.data.Take(this.index + 1).ToArray();
        }

        public Person Add(Person person)
        {
            if (this.people.Contains(person))
            {
                throw new InvalidOperationException("People already exist!");
            }

            this.people.Add(person);
            return person;
        }

        public Person Remove(Person person)
        {
            if (!this.people.Contains(person))
            {
                throw new InvalidOperationException($"{person.Username} not found!");
            }

            this.people.Remove(person);
            return person;
        }

        public Person FindByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("Username is not valid!");
            }
            if (!this.people.Any(x => x.Username == username))
            {
                throw new InvalidOperationException($"{username} not found!");
            }

            var currentPerson = this.people.First(x => x.Username == username);
            return currentPerson;
        }

        public Person FindById(long id)
        {
            if (!this.people.Any(x => x.Id == id))
            {
                throw new InvalidOperationException($"Username with this {id} not found!");
            }
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Id is not valid");
            }

            var currentPerson = this.people.First(x => x.Id == id);
            return currentPerson;
        }
    }
}
