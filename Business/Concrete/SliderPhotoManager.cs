using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SliderPhotoManager : ISliderPhotoManager
    {
        private readonly ISliderPhotoDal _sliderPhotoDal;

        public SliderPhotoManager(ISliderPhotoDal sliderPhotoDal)
        {
            _sliderPhotoDal = sliderPhotoDal;
        }

        public void Add(SliderPhoto SliderPhoto)
        {
            _sliderPhotoDal.Add(SliderPhoto);
        }

        public List<SliderPhoto> GetAllSliderPhoto()
        {
            return _sliderPhotoDal.GetAll();
        }
    }
}
