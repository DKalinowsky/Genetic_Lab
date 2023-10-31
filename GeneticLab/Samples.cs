using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticLab
{
    class Samples : Scientist
    {
        public int Chromosomes;
        public string StanSkupienia;
        public double Temperature;

        public Samples() : base()
        {
            Chromosomes = 0;
            StanSkupienia = "";
            Temperature = 0;
        }
        public Samples(int chrom, string ss, double temp)
        {
            Chromosomes = chrom;
            StanSkupienia = ss;
            Temperature = temp;
        }
    }
}
