using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeneticLab
{
    class Human : Samples
    {
        protected string Sex;

        public Human() : base()
        {
            Sex = "";
        }
        public Human(int chrom, string ss, double temp, string sex) : base(chrom, ss,  temp)
        {
            Sex = sex;
        }
        public override void CenterInformation()
        {
            WriteLine("The sample of Human have " + Chromosomes + " pairs of chromosomes, " + " the samples are taken from a " + Sex + " the sample of Human are in " + StanSkupienia + " and all the samples should be stored in " + Temperature + " Celcius degree");
        }
    }
}
