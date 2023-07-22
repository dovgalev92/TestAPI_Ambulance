using APi_Ambulance.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi_Ambulance.Domain.DTO.DToCallAmbul
{
    public class ReadCallAmbualnceDto
    {
        public int CallingAmbulanceId { get; set; }
        public string Name { get; set; }
        public string Family_Name { get; set; }
        public string Patronymic { get; set; }
        public string NameOfCAllAmbulance { get; set; }
        /// <summary>
        /// дата вызова
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime DateCall { get; set; }
        /// <summary>
        /// время вызова
        /// </summary>
        public TimeSpan TimeCall { get; set; }
        /// <summary>
        /// причина вызова
        /// </summary>
        public string CauseCall { get; set; }
        /// <summary>
        /// переадресация вызова в другую организацию 
        /// </summary>
        public string? RedirectCall { get; set; }
        public int NumberAccident_AssistantSquad { get; set; }
        /// <summary>
        /// дата выезда скорой
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime DateDepart { get; set; }
        /// <summary>
        /// время выезда скорой
        /// </summary>
        public TimeSpan TimeDepart { get; set; }
        /// <summary>
        /// время прибытия к пациенту
        /// </summary>
        public TimeSpan StartPatient { get; set; }
        /// <summary>
        /// время убытия 
        /// </summary>
        public TimeSpan EndTimePatient { get; set; }
        /// <summary>
        /// учреждения доставки 
        /// </summary>
        public string NameHospital { get; set; }
        public string Priority { get; set; }
        public string ResultDepart { get; set; }

    }
}
