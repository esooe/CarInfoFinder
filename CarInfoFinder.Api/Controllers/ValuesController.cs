using CarInfoFinder.Application.Interfaces;
using CarInfoFinder.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CarInfoFinder.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly IVehicleService _service;

        public ValuesController(IVehicleService service) => _service = service;

        [HttpGet("makes")]
        public async Task<IActionResult> GetAllMakes() =>
            await HandleAsync(async () => await _service.GetAllMakesAsync());

        [HttpGet("vehicle-types")]
        public async Task<IActionResult> GetVehicleTypes(int makeId) =>
            await HandleAsync(async () => await _service.GetVehicleTypesForMakeIdAsync(makeId));

        [HttpGet("models")]
        public async Task<IActionResult> GetModels(int makeId, int year) =>
            await HandleAsync(async () => await _service.GetModelsForMakeIdYearAsync(makeId, year));

        private async Task<IActionResult> HandleAsync<T>(Func<Task<T>> func)
        {
            try
            {
                var result = await func();
                return Ok(new ResponseDto<T> { Success = true, Data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ResponseDto<object>
                {
                    Success = false,
                    Message = ex.Message
                });
            }
        }
    }
}
