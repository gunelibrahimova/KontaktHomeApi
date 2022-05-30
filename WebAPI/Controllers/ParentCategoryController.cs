using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentCategoryController : ControllerBase
    {
        private readonly IParentCategoryManager _parentcategoryManager;

        public ParentCategoryController(IParentCategoryManager parentcategoryManager)
        {
            _parentcategoryManager = parentcategoryManager;
        }

        [HttpGet("getall")]
        public List<ParentCategory> GetAll()
        {
            return _parentcategoryManager.GetAllParentCategories();
        }

        [HttpPost("add")]
        public object AddParentCategory(ParentCategory parentcategory)
        {
            _parentcategoryManager.Add(parentcategory);
            return Ok("ParentCategory əlavə edildi");
        }

        [HttpPut("update")]
        public IActionResult UpdateParentCategory(ParentCategory parentcategory)
        {
            _parentcategoryManager.Update(parentcategory);
            return Ok(new { status = 200, message = parentcategory });
        }

        [HttpDelete("remove")]
        public IActionResult DeleteParentCategory(ParentCategory parentcategory)
        {
            _parentcategoryManager.Remove(parentcategory);
            return Ok("ParentCategory ugurla silindi.");
        }
    }
}
