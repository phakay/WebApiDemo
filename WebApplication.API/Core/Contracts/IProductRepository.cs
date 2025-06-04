using WebApplicationDemo.API.Core.Models;

namespace WebApplicationDemo.API.Core.Contracts
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        public void UpdateProduct(Product product);
    }
}
