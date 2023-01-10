using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class Person
    {
        string name, surname;
        int age;

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
        public override bool Equals(object obj)
        {
            return obj is Person person && this.name == person.name && this.surname == person.surname && this.age == person.age;
        }
        public override string ToString()
        {
            return this.name + " " + this.surname + " " + this.age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
