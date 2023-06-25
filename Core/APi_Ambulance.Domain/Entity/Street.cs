using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi_Ambulance.Domain.Entity
{
    public class Street
    {
        public int StreetId { get; set; }
        /// <summary>
        /// название улицы
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// номер дома
        /// </summary>
        public string NumberHouse { get; set; } = string.Empty;
        /// <summary>
        /// номер подъезда
        /// </summary>
        public string NumberEntranceOfHouse { get; set; } = string.Empty;
        /// <summary>
        /// номер квартиры
        /// </summary>
        public string NumberFlat { get; set; } = string.Empty;

        // связи

        public ICollection<Patient>? Patients { get; set; }
        public Locality? Locality { get; set; }
        public int LocalityId { get; set; }
    }
}
