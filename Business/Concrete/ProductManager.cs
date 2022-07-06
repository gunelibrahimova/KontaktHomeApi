using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductManager
    {
        private readonly IProductDal _productDal;
        private readonly IProductPictureManager _productPictureManager;

        public ProductManager(IProductDal productDal, IProductPictureManager productPictureManager)
        {
            _productDal = productDal;
            _productPictureManager = productPictureManager;
        }

        public void AddProduct(AddProductDTO productDTO)
        {
            Product product = new()
            {
                Name = productDTO.Name,
                Description = productDTO.Description,
                SecondParentCategoryId = productDTO.SecondParentCategoryId,
                Price = productDTO.Price,
                CoverPhoto = productDTO.CoverPhoto,
                SKU = productDTO.SKU,
                //CategoryId = productDTO.CategoryId

            };

            _productDal.Add(product);

            for (int i = 0; i < productDTO.ProductPicture.Count; i++)
            {
                productDTO.ProductPicture[i].ProductId = product.Id;
                _productPictureManager.AddProductPicture(productDTO.ProductPicture[i]);
            }
        }

        public List<ProductDTO> GetAllProductList()
        {
            return _productDal.GetAllProduct();
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public ProductDTO GetProductById(int id)
        {
            return _productDal.FindById(id);
        }

        public void Remove(Product product)
        {
           _productDal.Delete(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
