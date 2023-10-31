using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeneticLab
{
    class Program
    {
        static void Main(string[] args)
        {
            LabCenter Lab1 = new LabCenter(16734.7, 4, 1222, "FutureIsNow");
            Lab1.CenterInformation();
            ReadKey();

            GenLab Gen1 = new GenLab(128);
            Gen1.CenterInformation();
            ReadKey();

            Scientist Personel = new Scientist(128, 54, 74);
            Personel.CenterInformation();
            ReadKey();

            WriteLine("Every single scientist have only one sample");
            ReadKey();

            Personel.CenterInformation3();
            ReadKey();

            Human H1 = new Human(23, "liquid state", -20, "Man");
            H1.CenterInformation();
            ReadKey();

            Monkey M1 = new Monkey(24, "liquid state", -18.7, "Chimpanzee");
            M1.CenterInformation();
            ReadKey();

            MoreAdvancedHuman H2 = new MoreAdvancedHuman(23, "liquid state", -20, "Man", 89.6, "Female", 112);
            H2.CenterInformation();
            ReadKey();

            MoreAdvancedMonkey M2 = new MoreAdvancedMonkey(24, "liquid state", -18.7, "Chimpanzee", 14.3, "Chimpanzee", 98);
            M2.CenterInformation();
            ReadKey();

        }
    }
}
