using Microsoft.AspNetCore.Mvc;
using API_Ambulance.Application.GenericInterfaces;
using APi_Ambulance.Domain.DTO.DToCallAmbul;

namespace APi_Ambulance.Controllers.ControllerCallAmbulance
{
    [ApiController]
    [Route("api/[controller]")]
    public class CallAmbulanceController : ControllerBase
    {
        private readonly IBizServices<CreateCallAmbulDto> _bizServices;
        public CallAmbulanceController(IBizServices<CreateCallAmbulDto> bizServices)
        {
            _bizServices = bizServices;
        }

        // api/CallAmbulance/5
        [HttpPost("{id}")]
        public async Task<IActionResult> AddCommandCallAsync(int id, [FromBody] CreateCallAmbulDto dto)
        {
            if (!ModelState.IsValid)
            {
                return Ok("не корректные данные");
            }
            await _bizServices.InsertCommand(id, dto);
            return Ok("Операция проведена успешно");
        }
    }
}
