using WebApplicationDemo.API.Core.Contracts;
using WebApplicationDemo.API.Core.Models;

namespace WebApplicationDemo.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Product GetProduct(int id)
        {
            var result = _repository.GetById(id);

            return result;
        }
    }
}
