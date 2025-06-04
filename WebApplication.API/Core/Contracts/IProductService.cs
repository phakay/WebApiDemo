using WebApplicationDemo.API.Core.Models;

namespace WebApplicationDemo.API.Core.Contracts
{
    public interface IProductService
    {
        public Product GetProduct(int id);
    }
}
