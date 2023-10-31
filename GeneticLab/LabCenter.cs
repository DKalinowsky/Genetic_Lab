using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GeneticLab
{
    class LabCenter
    {
        public double Surface;
        public int NumberOfFloors;
        public int NumberOfRooms;
        public string Name;

        public LabCenter()
        {
            Surface = 0;
            NumberOfFloors = 0;
            NumberOfRooms = 0;
            Name = "";
        }
        public LabCenter(double surface, int nof, int nor, string name)
        {
            Surface = surface;
            NumberOfFloors = nof;
            NumberOfRooms = nor;
            Name = name;
        }
        public virtual void CenterInformation()
        {
            WriteLine("LabCenter named " + Name + " have " + Surface + " m^2 of surface, " + NumberOfFloors + " floors and " + NumberOfRooms + " of rooms in total.");
        }

    }
}
