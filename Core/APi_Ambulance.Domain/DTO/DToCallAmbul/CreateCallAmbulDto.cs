using APi_Ambulance.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi_Ambulance.Domain.DTO.DToCallAmbul
{
    public class CreateCallAmbulDto
    {
        public int CallingAmbulanceId { get; set; }
        /// <summary>
        /// дата вызова
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime DateCall { get; set; }
        /// <summary>
        /// время вызова
        /// </summary>
        [DataType(DataType.Time)]
        public DateTime TimeCall { get; set; }
        /// <summary>
        /// причина вызова
        /// </summary>
        public string? CauseCall { get; set; }
        /// <summary>
        /// переадресация вызова в другую организацию 
        /// </summary>
        public string? RedirectCall { get; set; }

        //связи
        public Patient? Patient { get; set; }
    }
}
