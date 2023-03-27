using Application.Dto.Product;
using Application.Mapper;
using Domain.Entities;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Application.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        private readonly IRepository<Category> _categoriesRepository;
        public ProductService(IRepository<Product> repository, IRepository<Category> categoriesRepository)
        {
            _repository = repository;
            _categoriesRepository = categoriesRepository;
        }
        public ProductDto GetProduct(int id)
        {
            var product = _repository.Query().Include(x => x.Category).FirstOrDefault(x => x.Id == id)
                ?? throw new Exception("Not found");

            var dto = product.ToProductDto();
            dto.CategoriesNames = GetCategoriesNames();

            return dto;
        }
        public IList<ProductDto> GetAllProducts()
        {
            var products = _repository.Query().Include(x => x.Category).Select(x => x.ToProductDto());

            return products.ToList();
        }
        public ProductDto AddProduct(AddProductDto dto)
        {
            var product = dto.ToProduct();
            product.Category = _categoriesRepository.GetById(dto.CategoryId) ?? throw new Exception();

            var created = _repository.Create(product);

            return created.ToProductDto();
        }
        public ProductDto EditProduct(AddProductDto dto, int id)
        {
            var product = _repository.GetById(id) ?? throw new Exception("Product not found");
            product.Category = _categoriesRepository.GetById(dto.CategoryId) ?? throw new Exception();

            var updated = product.Edit(dto);

            _repository.Update(updated);

            return updated.ToProductDto();
        }
        public void DeleteProduct(int id)
        {
            var product = _repository.GetById(id) ?? throw new Exception("Product not found");

            _repository.Delete(product);
        }
        public IList<string> GetCategoriesNames()
        {
            return _categoriesRepository.Query().Select(x => x.Name).ToList();
        }
        public CategoryDto GetCategory(int id)
        {
            var category = _categoriesRepository.GetById(id) ?? throw new Exception("Not found");

            return category.ToCategoryDto();
        }
        public IList<CategoryDto> GetCategories()
        {
            var categories = _categoriesRepository.Query().Select(x => x.ToCategoryDto());

            return categories.ToList();
        }
        public CategoryDto AddCategory(CategoryDto dto)
        {
            var category = new Category() { Name = dto.Name };

            var created = _categoriesRepository.Create(category);

            return created.ToCategoryDto();
        }
        public CategoryDto EditCategory(CategoryDto dto, int id)
        {
            var category = _categoriesRepository.GetById(id) ?? throw new Exception("Not found");

            category.Name = dto.Name;

            _categoriesRepository.Update(category);

            return category.ToCategoryDto();
        }
        public void DeleteCategory(int id)
        {
            var category = _categoriesRepository.GetById(id) ?? throw new Exception("Not found");

            _categoriesRepository.Delete(category);
        }
    }
}