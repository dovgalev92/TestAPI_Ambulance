
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
        
        // связи
        public CallingAmbulance Calling { get; set; }
        public int CallingAmbulanceId { get; set; }
    }
}
