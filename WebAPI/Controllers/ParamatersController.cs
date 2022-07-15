using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParamatersController : ControllerBase
    {
        private readonly IParametrsManager _parametrsManager;

        public ParamatersController(IParametrsManager parametrsManager)
        {
            _parametrsManager = parametrsManager;
        }

        [HttpGet("getall")]
        public List<Parametrs> GetAll()
        {
            return _parametrsManager.GetAll();
        }

        [HttpPost("add")]
        public object AddParametrs(Parametrs Parametrs)
        {
            _parametrsManager.Add(Parametrs);
            return Ok("Parametrs əlavə edildi.");
        }

        [HttpPut("update")]
        public IActionResult UpdateParametrs(Parametrs Parametrs)
        {
            _parametrsManager.Update(Parametrs);
            return Ok(new { status = 200, message = Parametrs });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteParametrs(Parametrs Parametrs)
        {
            _parametrsManager.Remove(Parametrs);
            return Ok("Parametrs ugurla silindi.");
        }
    }
}
