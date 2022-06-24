using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repositories.Contarcts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItems(int id);
        Task<ProductCategory> GetCategory(int id);
    }
}
