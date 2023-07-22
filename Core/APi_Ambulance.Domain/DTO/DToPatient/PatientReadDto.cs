
using APi_Ambulance.Domain.Entity;

namespace APi_Ambulance.Domain.DTO.DToPatient
{
    public class PatientReadDto
    {
        public int PatientId { get; set; }
        /// <summary>
        /// имя пациента
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// фамиля пациента
        /// </summary>
        public string? Family_Name { get; set; }
        /// <summary>
        /// отчество пациента
        /// </summary>
        public string? Patronymic { get; set; }
        public DateTime BirthYear { get; set; }
        public string NameLocality { get; set; }
        public string NameStreet { get; set; }
        public string NumberHouse { get; set; }
        /// <summary>
        /// номер подъезда
        /// </summary>
        public string NumberEntranceOfHouse { get; set; }
        /// <summary>
        /// номер квартиры
        /// </summary>
        public string NumberFlat { get; set; }
    }
}
