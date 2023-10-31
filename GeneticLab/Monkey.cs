using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeneticLab
{
    class Monkey : Samples
    {
        protected string Gatunek;

        public Monkey() : base()
        {
            Gatunek = "";
        }
        public Monkey(int chrom, string ss, double temp, string gat) : base(chrom, ss, temp)
        {
            Gatunek = gat;
        }
        public override void CenterInformation()
        {
            WriteLine("The sample of Monkey have " + Chromosomes + " pairs of chromosomes, " + " the samples are taken from a " + Gatunek + " the sample of Monkey are in " + StanSkupienia + " and all the samples should be stored in " + Temperature + " Celcius degree");
        }
    }
}
