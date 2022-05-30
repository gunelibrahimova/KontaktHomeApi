using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CoverPhoto { get; set; }
        public bool IsSlider { get; set; }
        public string SKU { get; set; }
        public bool IsStock { get; set; }
        public int SecondParentCategoryId { get; set; }
        public SecondParentCategory SecondParentCategory { get; set; }
        public List<ProductPicture> ProductPicture { get; set; }
    }
}
