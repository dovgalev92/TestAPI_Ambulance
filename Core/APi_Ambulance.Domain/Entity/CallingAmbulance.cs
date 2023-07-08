using System.ComponentModel.DataAnnotations;

namespace APi_Ambulance.Domain.Entity
{
    public class CallingAmbulance
    {
        public int CallingAmbulanceId { get; set; }
        /// <summary>
        /// имя, фамилия кто сделал вызов(пациент или сторонний человек)
        /// </summary>
        public string Name { get; set; }
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

        //связи
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public AmbulanceDeparture Departure { get; set; }
    }
}
