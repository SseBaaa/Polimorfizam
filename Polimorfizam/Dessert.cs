using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class Dessert
    {
        private string name;
        private double weight;
        private int calories;

        public Dessert(string name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }
        public override string ToString()
        {
            return this.name + this.Weight + this.calories;
        }
        virtual public string getDessertType()
        {
            return "dessert";
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }
    }
}
