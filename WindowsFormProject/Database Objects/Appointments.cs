using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormProject.Database_Objects
{
    public class Appointments
    {
        public int DateID { get; set; }

        public int VetID { get; set; }

        public int PetID { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public string Reason { get; set; }
    }
}
