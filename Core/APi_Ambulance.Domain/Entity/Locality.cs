using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi_Ambulance.Domain.Entity
{
    public class Locality
    {
        public int LocalityId { get; set; }
        public string NameLocality { get; set; } = string.Empty;

        //связи
        public ICollection<Patient>? Patients { get; set; }
        public ICollection<Street>? Streets { get; set; }
    }
}
