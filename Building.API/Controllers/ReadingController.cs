using Building.BLL.Services;
using Building.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Building.API.Controllers
{
    [ApiController]
    public class ReadingController : ControllerBase
    {
        private readonly IReadingService _readingService;

        public ReadingController(IReadingService readingService)
        {
            _readingService = readingService;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public async Task<IActionResult> GetAll()
        {
            var data = await _readingService.GetAllAsync();

            return Ok(data);
        }

        [HttpGet]
        [Route("api/[controller]/Filter")]
        public async Task<IActionResult> GetAll([FromQuery] ReadingDto readingDto)
        {
            var data = await _readingService.GetAllFilteredAsync(readingDto);

            return Ok(data);
        }
    }
}
