using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderPhotoController : ControllerBase
    {
        private readonly ISliderPhotoManager _sliderPhotoManager;

        public SliderPhotoController(ISliderPhotoManager sliderPhotoManager)
        {
            _sliderPhotoManager = sliderPhotoManager;
        }

        [HttpPost("add")]
        public object AddSliderPhoto(SliderPhoto sliderPhoto)
        {
            _sliderPhotoManager.Add(sliderPhoto);
            return Ok("Photo əlavə edildi.");
        }

        [HttpGet("getall")]
        public List<SliderPhoto> GetAll()
        {
            return _sliderPhotoManager.GetAllSliderPhoto();
        }

    }
}
