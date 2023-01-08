using DrinksShop.Api.Entities;
using Microsoft.EntityFrameworkCore;
using DrinksShop.Api.Data;
using DrinksShop.Api.Repositories.Contracts;

namespace DrinksShop.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DrinksShopDbContext drinksShopDbContext;

        public ProductRepository(DrinksShopDbContext drinksShopDbContext)
        {
            this.drinksShopDbContext = drinksShopDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.drinksShopDbContext.ProductCategories.ToListAsync();

            return categories;

        }

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await drinksShopDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await drinksShopDbContext.Products
                                .Include(p => p.ProductCategory)
                                .SingleOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.drinksShopDbContext.Products
                                     .Include(p => p.ProductCategory).ToListAsync();

            return products;

        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
            var products = await this.drinksShopDbContext.Products
                                     .Include(p => p.ProductCategory)
                                     .Where(p => p.CategoryId == id).ToListAsync();
            return products;
        }
    }
}
