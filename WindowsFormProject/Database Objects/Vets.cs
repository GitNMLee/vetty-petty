using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormProject.Database_Objects
{
    public class Vets
    {
        public int VetID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime? TermiationDate { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
