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
        private readonly IBizServiceReadCallAmbulance _bizServiceReadCall;
        public CallAmbulanceController(IBizServices<CreateCallAmbulDto> bizServices, IBizServiceReadCallAmbulance bizServiceReadCall)
        {
            _bizServices = bizServices;
            _bizServiceReadCall = bizServiceReadCall;
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
        [HttpGet("{id}")]
        public async Task<ReadCallAmbualnceDto> ReadCommandCallAmbualnce(int id)
        {
            if(!ModelState.IsValid)
            {
                throw new ArgumentNullException(nameof(id));
            }
           return await _bizServiceReadCall.ReadCommandAsync(id);

        }
    }
}
