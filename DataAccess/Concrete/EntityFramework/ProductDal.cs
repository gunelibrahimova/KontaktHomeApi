using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class ProductDal : EfEntityRepositoryBase<Product, KontaktDbContext>, IProductDal
    {
        public ProductDTO FindById(int id)
        {
            using (KontaktDbContext context = new())
            {
                var product = context.Products.Include(x => x.SecondParentCategory).FirstOrDefault(x => x.Id == id);
                var productPictures = context.ProductPictures.Where(x => x.ProductId == id).ToList();
                var comments = context.Comments.Where(x => x.ProductId == product.Id).ToList();

                decimal ratingSum = 0;
                int ratingCount = 0;

                List<CommentDTO> commentResult = new();

                for (int i = 0; i < comments.Count; i++)
                {
                    CommentDTO comment = new()
                    {
                        ProductId = product.Id,
                        UserEmail = comments[i].UserEmail,
                        UserName = comments[i].UserName,
                        Ratings = comments[i].Ratings,
                        Review = comments[i].Review
                    };
                    commentResult.Add(comment);
                }

                List<string> pictures = new();

                foreach (var picture in productPictures)
                {
                    pictures.Add(picture.PhotoURL);
                }
                foreach (var rating in comments.Where(x => x.Ratings != 0))
                {
                    ratingCount++;
                    ratingSum += rating.Ratings;
                }

                if (ratingCount == 0)
                    ratingSum = 0;
                else
                    ratingSum = ratingSum / ratingCount;


                ProductDTO result = new()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    SecondParentCategoryName = product.SecondParentCategory.Name,
                    Price = product.Price,
                    ReviewCount = ratingCount,
                    ProductPictures = pictures,
                    CoverPhoto = product.CoverPhoto,
                    IsSlider = product.IsSlider,
                    SKU = product.SKU,
                    IsStock = product.IsStock,
                    Marka = product.Marka,
                    Model = product.Model,
                    Ceki = product.Ceki,
                    Ekran = product.Ekran,
                    Kamera = product.Kamera,
                    RAM = product.RAM,
                    ROM = product.ROM,
                    Processor = product.Processor,

                    Rating = Math.Round(ratingSum, 1),
                    Comments = commentResult,
                };

                return result;
            }
        }

        public List<ProductDTO> GetAllProduct()
        {
            using (KontaktDbContext context = new())
            {
                var products = context.Products.Include(x => x.SecondParentCategory).Include(x => x.ProductPicture).ToList();
                var productPictures = context.ProductPictures;

                var ratings = context.Comments;

                List<ProductDTO> result = new();

                for (int i = 0; i < products.Count; i++)
                {
                    decimal ratingSum = 0;
                    int ratingCount = 0;
                    List<string> pictures = new();

                    foreach (var item in productPictures.Where(x => x.ProductId == products[i].Id))
                    {
                        pictures.Add(item.PhotoURL);
                    }

                    foreach (var rating in ratings.Where(x => x.ProductId == products[i].Id && x.Ratings != 0))
                    {

                        ratingCount++;
                        ratingSum += rating.Ratings;
                    }

                    if (ratingCount == 0)
                    {
                        ratingSum = 0;
                    }
                    else
                    {
                        ratingSum = ratingSum / ratingCount;
                    }

                    ProductDTO productList = new()
                    {
                        Id = products[i].Id,
                        Name = products[i].Name,
                        Description = products[i].Description,
                        SecondParentCategoryName = products[i].SecondParentCategory.Name,
                        Price = products[i].Price,
                        ProductPictures = pictures,
                        CoverPhoto = products[i].CoverPhoto,
                        IsSlider = products[i].IsSlider,
                        Rating = Math.Round(ratingSum, 1),
                        SKU = products[i].SKU,
                        IsStock = products[i].IsStock,
                        Marka = products[i].Marka,
                        Model = products[i].Model,
                        Ceki = products[i].Ceki,
                        Ekran = products[i].Ekran,
                        Kamera = products[i].Kamera,
                        RAM = products[i].RAM,
                        ROM = products[i].ROM,
                        Processor = products[i].Processor,
                    };
                    result.Add(productList);
                }
                return result;
            }
        }
    }
}
