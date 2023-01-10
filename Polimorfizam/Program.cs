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
            Dessert genericDessert = new Dessert("Chocolate Mousse", 120, 300);
            Kolac cake = new Kolac("Raspberry chocolate cake #3", 350.5, 400, false, "birthday");
            Teacher t1 = new Teacher("Dario", "Tušek", 42, "dario.tusek@fer.hr", "OOP", 10000);
            Teacher t2 = new Teacher("Doris", "Bezmalinović", 43, "doris.bezmalinovic@fer.hr",
            "OOP", 10000);
            Student s1 = new Student("Janko", "Horvat", 18, "0036312123", (short)1);
            Student s2 = new Student("Ana", "Kovač", 19, "0036387656", (short)2);
            Student s3 = new Student("Ivana", "Stanić", 19, "0036392357", (short)1);
            UniMasterChef competition = new UniMasterChef(2);
            CompetitionEntrycs e1 = new CompetitionEntrycs(t1, genericDessert);
            competition.addEntry(e1);
            Console.WriteLine("Entry 1 rating: " + e1.getRating());
            e1.addEntry(s1, 4);
            e1.addEntry(s2, 5);
            Console.WriteLine("Entry 1 rating: " + e1.getRating());
            CompetitionEntrycs e2 = new CompetitionEntrycs(t2, cake);
            e2.addEntry(s1, 4);
            e2.addEntry(s3, 5);
            e2.addEntry(s2, 5);
            competition.addEntry(e2);
            Console.WriteLine("Entry 2 rating: " + e2.getRating());
            Console.WriteLine("Best dessert is: " + competition.getBestDessert().Name);
        }
    }
}
