using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    internal class UniMasterChef
    {
		private CompetitionEntrycs[] entries;

		
		private int idx = 0;

		public UniMasterChef(int noOfEntries)
		{
			this.entries = new CompetitionEntrycs[noOfEntries];
		}
		public bool addEntry(CompetitionEntrycs entry)
		{
			if (idx == this.entries.Length) return false;


			entries[idx++] = entry;
			return true;
		}
		public Dessert getBestDessert()
		{
			if (idx == 0) return null;

			double max = entries[0].getRating();
			int maxIdx = 0;

			for (int i = 0; i < idx; i++)
			{
				if (entries[i].getRating() > max)
				{
					max = entries[i].getRating();
					maxIdx = i;
				}
			}

			return entries[maxIdx].Dessert;
		}
		public static Person[] getInvolvedPeople(CompetitionEntrycs entry)
		{

			Person[] retVal = new Person[4]; 

			int idx = 0;

			retVal[idx++] = entry.Teacher;

			

			return retVal;
		}
	}
}
