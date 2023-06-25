using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi_Ambulance.Domain.Entity
{
    public class AmbulanceDeparture
    {
        public int AmbulanceDepartureId { get; set; }
        /// <summary>
        /// номер бригады скорой
        /// </summary>
        public int NumberAccident_AssistantSquad { get; set; }
        /// <summary>
        /// дата выезда скорой
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime DateDepart { get; set; }
        /// <summary>
        /// время выезда скорой
        /// </summary>
        [DataType(DataType.Time)]
        public DateTime TimeDepart { get; set; }
        /// <summary>
        /// время прибытия к пациенту
        /// </summary>
        [DataType(DataType.Time)]
        public DateTime StartPatient { get; set; }
        /// <summary>
        /// время убытия 
        /// </summary>
        [DataType(DataType.Time)]
        public DateTime EndTimePatient { get; set; }
        /// <summary>
        /// учреждения доставки 
        /// </summary>
        public string? NameHospital { get; set; }


        // связи
        public Patient? Patient { get; set; }
        public int PatientId { get; set; }
    }
}
