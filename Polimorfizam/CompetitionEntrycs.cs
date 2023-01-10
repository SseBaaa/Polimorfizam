using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class CompetitionEntrycs
    {
        Teacher teacher;
        Dessert dessert;
        Student student;
        private int[] ratings;
        private int idx;
        public CompetitionEntrycs(Teacher teacher, Dessert dessert)
        {
            this.teacher = teacher;
            this.dessert = dessert;
        }

        public bool addEntry(Teacher teacher, int number)
        {
            if (idx == 3)
            {
                return false;
            }
            else
                return true;
            

        }
        public double getRating()
        {
            if (idx == 0) return 0;

            double sum = 0;
            for (int i = 0; i < idx; i++)
                sum += ratings[i];

            return sum / idx;
        }

        internal Teacher Teacher { get => teacher; set => teacher = value; }
        internal Dessert Dessert { get => dessert; set => dessert = value; }
        internal Student Student { get => student; set => student = value; }
        public int[] Ratings { get => ratings; set => ratings = value; }
        public int Idx { get => idx; set => idx = value; }
    }
}
