using Application.Dto.Product;
using Domain.Entities;

namespace Application.Mapper
{
    public static class ProductsMapper
    {
        public static ProductDto ToProductDto(this Product product)
        {
            return new()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                CategoryName = product.Category.Name,
                ImgSrc = product.ImgSrc
            };
        }
        public static SelectProductDto ToSelectProductDto(this ProductDto product)
        {
            return new()
            {
                ProductId = product.Id,
                ProductName = product.Name,
                ProductPrice = product.Price,
                IsSelected = true,
                Quantity = 0,

            };
        }
        public static Product ToProduct(this AddProductDto add)
        {
            return new(add.Name, add.Description, add.Price, add.ImgSrc);
        }
        public static Product Edit(this Product product, AddProductDto dto)
        {
            product.Name = dto.Name;
            product.Price = dto.Price;
            product.Description = dto.Description;
            product.ImgSrc = dto.ImgSrc;
            return product;
        }

        public static CategoryDto ToCategoryDto(this Category category)
        {
            return new()
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
    }
}