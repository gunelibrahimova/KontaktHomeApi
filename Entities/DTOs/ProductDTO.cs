﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public string? Ekran { get; set; }
        public string? RAM { get; set; }
        public string? ROM { get; set; }
        public string? Processor { get; set; }
        public string? Kamera { get; set; }
        public string? Ceki { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ReviewCount { get; set; }
        public string SecondParentCategoryName { get; set; }
        public string CoverPhoto { get; set; }
        public bool IsSlider { get; set; }
        public decimal Rating { get; set; }
        public string SKU { get; set; }
        public bool IsStock { get; set; }
        public List<string> ProductPictures { get; set; }
        public List<CommentDTO> Comments { get; set; }
    }
}
