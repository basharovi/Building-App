using Building.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Building.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingController : ControllerBase
    {
        private readonly IReadingService _readingService;

        public ReadingController(IReadingService readingService)
        {
            _readingService = readingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _readingService.GetAllAsync();

            return Ok(data);
        }
    }
}
