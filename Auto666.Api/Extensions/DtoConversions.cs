using Auto666.Api.Entities;
using Auto666.Models.Dtos;

namespace Auto666.Api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductCategoryDto> ConvertToDto(this IEnumerable<ProductCategory> productCategories)
        {
            return (from productCategory in productCategories
                    select new ProductCategoryDto
                    {
                        Id = productCategory.Id,
                        Name = productCategory.Name,
                        Icon = productCategory.Icon
                    }).ToList();
        }
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products)
        {
            return (from product in products
                    select new ProductDto
                    {
                        Id = product.Id,
                        Name = product.Name,
                        Model = product.Model,
                        Mark = product.Mark,
                        Description = product.Description,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Year = product.Year,
                        Transmission = product.Transmission,
                        Range = product.Range,
                        City = product.City,
                        Volume = product.Volume,
                        Horses = product.Horses,
                        FuelType = product.FuelType,
                        CategoryId = product.ProductCategory.Id,
                        CategoryName = product.ProductCategory.Name
                    }).ToList();

        }
        public static ProductDto ConvertToDto(this Product product)

        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Model = product.Model,
                Mark = product.Mark,
                Description = product.Description,
                ImageURL = product.ImageURL,
                Price = product.Price,
                Year = product.Year,
                Transmission = product.Transmission,
                Range = product.Range,
                City = product.City,
                Volume = product.Volume,
                Horses = product.Horses,
                FuelType = product.FuelType,
                CategoryId = product.ProductCategory.Id,
                CategoryName = product.ProductCategory.Name

            };
        }
    }
}
