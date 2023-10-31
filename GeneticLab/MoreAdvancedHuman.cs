using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeneticLab
{
    class MoreAdvancedHuman : Human
    {
        private double Avarage;
        private string Gender;
        private double IQ;

        public MoreAdvancedHuman(int chrom, string ss, double temp, string sex, double avg, string gen, double iq) : base(chrom, ss, temp, sex)
        {
            Avarage = avg;
            Gender = gen;
            IQ = iq;
        }
        public override void CenterInformation()
        {
            WriteLine("Avarage lenght of life of human is " + Avarage + " years. And examined sample is " + Gender + " and have " + IQ + " iq.");
        }
    }
}
