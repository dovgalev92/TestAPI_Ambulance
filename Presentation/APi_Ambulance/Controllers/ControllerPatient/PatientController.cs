using APi_Ambulance.Domain.DTO.DTOPatient;
using APi_Ambulance.Domain.Entity;
using API_Ambulance.Application.GenericInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace APi_Ambulance.Controllers.ControllerPatient
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IBizServicesPatient<PatientWriteDto, Patient> _bizServices;
        public PatientController(IBizServicesPatient<PatientWriteDto, Patient> bizServices)
        {
            _bizServices = bizServices;
        }
        // api/Patinet
        [HttpPost]
        public IActionResult AddCommand([FromBody] PatientWriteDto dto)
        {
            _bizServices.AddCommandServices(dto);
            return Ok("Данные успешно добавлены");
        }

        
    }

}
