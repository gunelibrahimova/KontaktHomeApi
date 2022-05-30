using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecondParentCategoryController : ControllerBase
    {
        private readonly ISecondParentCategoryManager _secondParentCategoryManager;

        public SecondParentCategoryController(ISecondParentCategoryManager secondParentCategoryManager)
        {
            _secondParentCategoryManager = secondParentCategoryManager;
        }

        [HttpGet("getall")]
        public List<SecondParentCategory> GetAll()
        {
            return _secondParentCategoryManager.GetAllSecondParentCategories();
        }

        [HttpPost("add")]
        public object AddSecondParentCategory(SecondParentCategory secondparentcategory)
        {
            _secondParentCategoryManager.Add(secondparentcategory);
            return Ok("SecondParentCategory əlavə edildi");
        }

        [HttpPut("update")]
        public IActionResult UpdateSecondParentCategory(SecondParentCategory secondparentcategory)
        {
           _secondParentCategoryManager.Update(secondparentcategory);
            return Ok(new { status = 200, message = secondparentcategory });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteSecondParentCategory(SecondParentCategory secondparentcategory)
        {
            _secondParentCategoryManager.Remove(secondparentcategory);
            return Ok("SecondParentCategory ugurla silindi.");
        }
    }
}
