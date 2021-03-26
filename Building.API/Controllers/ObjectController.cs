using Building.BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Building.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private readonly IDropdownLoadService _dropdownLoadService;

        public ObjectController(IDropdownLoadService dropdownLoadService)
        {
            _dropdownLoadService = dropdownLoadService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _dropdownLoadService.GetObjectDropdownDataAsync();

            return Ok(data);
        }
    }
}
