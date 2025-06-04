using WebApplicationDemo.API.Core.Contracts;
using WebApplicationDemo.API.Core.Models;

namespace WebApplicationDemo.API.Repositories
{
    public class ProductRepository : InMemoryRepository<Product>, IProductRepository
    {
        public ProductRepository()
        {
            _items = new List<Product>();
            _items.Add(new Product 
            { 
                Id = 1,
                Name = "Test"
            });
        }

        public void UpdateProduct(Product product)
        {
            _items.Add(product);
        }
    }
}
