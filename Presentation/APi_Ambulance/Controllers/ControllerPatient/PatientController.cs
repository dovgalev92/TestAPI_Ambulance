using APi_Ambulance.Domain.DTO.DToPatient;

using APi_Ambulance.Domain.Entity;
using API_Ambulance.Application.Automapper.Patients;
using API_Ambulance.Application.GenericInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace APi_Ambulance.Controllers.ControllerPatient
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IBizServicesPatient<PatientWriteDto, PatientReadDto> _bizServices;
        public PatientController(IBizServicesPatient<PatientWriteDto, PatientReadDto> bizServices)
        {
            _bizServices = bizServices;
        }
        // api/Patinet
        [HttpPost]
        public IActionResult AddCommandPatientAsync([FromBody] PatientWriteDto dto)
        {
            _bizServices.AddCommandServices(dto);
            return Ok("Данные успешно добавлены");
        }
        [HttpGet("{id}")]
        public async Task<PatientReadDto> ReadCommandPatientAsync(int id)
        {
            return await _bizServices.GetCommandIdServices(id);
        }

        
    }

}
