using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class IceCream : Dessert
    {
        string color, flavour;
        public IceCream(string name, double weight, int calories, string color, string flavour) : base(name, weight, calories)
        {
            this.color = color;
            this.flavour = flavour;
        }
        public override string ToString()
        {
            return base.ToString() + this.color + this.flavour;
        }

        public override string getDessertType()
        {
            return "ice cream";
        }

        public string Color { get => color; set => color = value; }
        public string Flavour { get => flavour; set => flavour = value; }
    }
}
