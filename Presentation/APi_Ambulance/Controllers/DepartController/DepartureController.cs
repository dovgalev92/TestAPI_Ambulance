using APi_Ambulance.Domain.DTO.DtoCallDepartrure;
using API_Ambulance.Application.GenericInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace APi_Ambulance.Controllers.DepartController
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartureController : ControllerBase
    {
        private readonly IBizServices<AmbulanceDepartureDto> _services;
        public DepartureController(IBizServices<AmbulanceDepartureDto> services)
        {
            _services = services;
        }
        [HttpPost("{id}")]
        public async Task<IActionResult> AddCommandDepartAsync(int id, [FromBody] AmbulanceDepartureDto departure)
        {
            await _services.InsertCommand(id, departure);
            return Ok("Вызов добавлен");
        }
    }
}
