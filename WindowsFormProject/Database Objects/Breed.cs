using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormProject.Database_Objects
{
    public class Breed
    {
        public int BreedID { get; set; }
        public int SpeciesID { get; set; }
        public string BreedName { get; set; }

        public override string ToString()
        {
            return BreedName;
        }
    }
}
