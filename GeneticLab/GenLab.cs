using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeneticLab
{
    class GenLab : LabCenter
    {
        protected int NumberOfScientists;

        public GenLab() : base()
        {
            NumberOfScientists = 0;
        }
        public GenLab(int nos)
        {
            NumberOfScientists = nos;
        }

        public void ShowNumberOfEmployes()
        {
            WriteLine("Number of employes in Genetic Department is " + NumberOfScientists);
        }
        public override void CenterInformation() 
        {
            WriteLine("Number of employes in Genetic Department is " + NumberOfScientists);
        }
    }
}
