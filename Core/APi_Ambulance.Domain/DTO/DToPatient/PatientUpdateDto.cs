

namespace APi_Ambulance.Domain.DTO.DTOPatient
{
    public class PatientUpdateDto
    {
        /// <summary>
        /// имя пациента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// фамиля пациента
        /// </summary>
        public string Family_Name { get; set; }
        /// <summary>
        /// отчество пациента
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// возраст(полных лет)
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// год рождения
        /// </summary>
        public DateTime BirthYear { get; set; }
    }
}
