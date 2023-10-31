using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeneticLab
{
    class MoreAdvancedMonkey : Monkey
    {
        private double Avarage;
        private string Gatunek;
        private double Long;

        public MoreAdvancedMonkey(int chrom, string ss, double temp, string sex, double avg, string gat, double longt) : base(chrom, ss, temp, sex)
        {
            Avarage = avg;
            Gatunek = gat;
            Long = longt;
        }
        public override void CenterInformation()
        {
            WriteLine("Avarage lenght of life of monkey is " + Avarage + " years. And examined sample is " + Gatunek + " and have " + Long + " cm lenght of tail.");
        }
    }
}
