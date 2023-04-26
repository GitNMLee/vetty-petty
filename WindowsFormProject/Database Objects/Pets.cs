using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormProject.Database_Objects
{
    public class Pets
    {
        public int PetID { get; set; }

        public int OwnerID { get; set; }

        public int BreedID { get; set;  }

        public string PetFirstName { get; set; }

        public string PetLastName { get; set; }

        public string Description { get; set; }

        public DateTime? DeceasedOn { get; set; }

        public override string ToString()
        {
            return PetFirstName + " " + PetLastName;
        }
    }
}
