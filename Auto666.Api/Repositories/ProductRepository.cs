using Auto666.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Auto666.Api.Data;
using Auto666.Api.Repositories.Contracts;

namespace Auto666.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Auto666DbContext Auto666DbContext;

        public ProductRepository(Auto666DbContext Auto666DbContext)
        {
            this.Auto666DbContext = Auto666DbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.Auto666DbContext.ProductCategories.ToListAsync();

            return categories;

        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await Auto666DbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await Auto666DbContext.Products
                                .Include(p => p.ProductCategory)
                                .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.Auto666DbContext.Products
                                     .Include(p => p.ProductCategory).ToListAsync();

            return products;

        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await this.Auto666DbContext.Products
                                     .Include(p => p.ProductCategory)
                                     .Where(p => p.CategoryId == id).ToListAsync();
            return products;
        }
    }
}
