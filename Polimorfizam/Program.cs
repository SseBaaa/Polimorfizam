using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivo", "Ivic", 20);
            Person p2 = new Person("Ivo", "Ivic", 20);
            Person p3 = new Student("Ivo", "Ivic", 20, "0036312123", (short)3);
            Person p4 = new Student("Marko", "Marić", 25, "0036312123", (short)5);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p3.Equals(p4));
            Console.ReadKey();
        }
    }
}
