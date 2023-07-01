using APi_Ambulance.Domain.Enum;
using System.ComponentModel.DataAnnotations;


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
        /// <summary>
        /// возраст(полных лет)
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// год рождения
        /// </summary>
        public DateTime BirthYear { get; set; }
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
        public string? CauseCall { get; set; }
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
        public string? NameHospital { get; set; }
        /// <summary>
        /// приоритет вызова
        /// </summary>
        public string?  Priority { get; set; }
        /// <summary>
        /// результат выезда к пациенту
        /// </summary>
        public string? ResultDepart { get; set; }

    }
}
