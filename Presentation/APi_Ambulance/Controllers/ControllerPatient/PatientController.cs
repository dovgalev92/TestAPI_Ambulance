using APi_Ambulance.Domain.DTO.DToPatient;
using APi_Ambulance.Domain.DTO.DTOPatient;
using API_Ambulance.Application.GenericInterfaces;
using Microsoft.AspNetCore.Mvc;


namespace APi_Ambulance.Controllers.ControllerPatient
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IBizServicesPatient<PatientWriteDto, PatientReadIdDto, PatientUpdateDto, PatientReadDto> _bizServices;
        public PatientController(IBizServicesPatient<PatientWriteDto, PatientReadIdDto,PatientUpdateDto, PatientReadDto> bizServices)
        {
            _bizServices = bizServices;
        }
        // api/Patient
        [HttpPost]
        public  async Task<IActionResult> AddCommandAsync([FromBody] PatientWriteDto dto)
        {
            if (ModelState.IsValid)
            {
                return NotFound();
            }
            await _bizServices.AddCommandServices(dto);
            return Ok("Данные успешно добавлены");
        }
        // api/Patient/ 5
        [HttpGet("{id}")]
        public async Task<PatientReadIdDto> ReadCommandIdAsync(int id)
        {
            return await _bizServices.GetCommandIdServices(id);
        }
        // api/Patient
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientReadDto>>> ReadCommandAll()
        {
            return Ok(await _bizServices.GetAllCommandServices());
        }
        // api/Patient
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCommand(int id, [FromBody] PatientUpdateDto writeDto)
        {
           if(!ModelState.IsValid)
           {
                return NoContent();
           }
           await _bizServices.UpdateCommandServices(id, writeDto);
           return Ok("Данные успешно обновлены");
        }


    }

}
