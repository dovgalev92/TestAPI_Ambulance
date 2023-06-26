using Microsoft.AspNetCore.Mvc;
using APi_Ambulance.Domain.DTO;
using APi_Ambulance.Domain.Entity;
using API_Ambulance.Application.GenericInterfaces;
using API_Ambulance.Application.Automapper.CallAmbulance;

namespace APi_Ambulance.Controllers.ControllerCallAmbulance
{
    [ApiController]
    [Route("api/[controller]")]
    public class CallAmbulabceController : ControllerBase
    {
        private readonly IBizServices<CallAmbulCreatMap> _bizServices;
        public CallAmbulabceController(IBizServices<CallAmbulCreatMap> bizServices)
        {
            _bizServices = bizServices;
        }

        // api/CallAmbulance/5
        [HttpPost("{id}")]
        public async Task<IActionResult> AddCommand(int id, [FromBody] CallAmbulCreatMap dto)
        {
            await _bizServices.InsertCommand(id, dto);
            return Ok("Операция проведена успешно");
        }
    }
}
