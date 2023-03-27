using Application.Dto.Product;

namespace Application.Services
{
    public interface IProductService
    {
        IList<ProductDto> GetAllProducts();
        ProductDto GetProduct(int id);
        ProductDto AddProduct(AddProductDto dto);
        ProductDto EditProduct(AddProductDto dto, int id);
        void DeleteProduct(int id);
        IList<string> GetCategoriesNames();
        CategoryDto GetCategory(int id);
        IList<CategoryDto> GetCategories();
        CategoryDto AddCategory(CategoryDto dto);
        CategoryDto EditCategory(CategoryDto dto, int id);
        void DeleteCategory(int id);
    }
}