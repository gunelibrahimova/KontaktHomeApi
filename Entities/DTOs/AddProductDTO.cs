using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AddProductDTO
    {
        public string Name { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? Ekran { get; set; }
        public string? RAM { get; set; }
        public string? ROM { get; set; }
        public string? Processor { get; set; }
        public string? Kamera { get; set; }
        public string? Ceki { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int SecondParentCategoryId { get; set; }
        //public int CategoryId { get; set; }
        public string CoverPhoto { get; set; }
        public bool IsSlider { get; set; }
        public string SKU { get; set; }
        public bool IsStock { get; set; }
        public List<ProductPictureDTO> ProductPicture { get; set; }
    }
}
