using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeneticLab
{
    class Scientist : GenLab
    {
        protected int NumberOfFemaleScientists;
        protected int NumberOfMaleScientists;

        public Scientist() : base()
        {
            NumberOfFemaleScientists = 0;
            NumberOfMaleScientists = 0;
        }

        public Scientist(int nos, int nofs, int noms) : base(nos)
        {
            NumberOfFemaleScientists = nofs;
            NumberOfMaleScientists = noms;
            NumberOfScientists = nos;
            if (nos != noms + nofs)
            {
                Environment.Exit(0);
            }
        }
        public override void CenterInformation()
        {
            
            WriteLine("From which " + NumberOfFemaleScientists + " are famale and " + NumberOfMaleScientists + " are male");
        }
        public void CenterInformation3()
        {
            WriteLine("So in total there are " + NumberOfScientists + " samples");
        }
    }
}
