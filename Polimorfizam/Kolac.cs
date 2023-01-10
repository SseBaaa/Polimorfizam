using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class Kolac:Dessert
    {
        bool containsGluten;
        string cakeType;

        public Kolac(string name, double weight, int calories, bool containsGluten, string cakeType) : base(name, weight, calories)
        {
            this.ContainsGluten = containsGluten;
            this.CakeType = cakeType;
        }

        public override string getDessertType()
        {
            return cakeType + "cake";
        }
        public override string ToString()
        {
            return base.ToString() + this.containsGluten + this.cakeType;
        }


        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string CakeType { get => cakeType; set => cakeType = value; }
    }
}
