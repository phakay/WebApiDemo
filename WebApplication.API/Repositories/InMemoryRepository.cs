using WebApplicationDemo.API.Core.Contracts;
using WebApplicationDemo.API.Core.Models;

namespace WebApplicationDemo.API.Repositories
{
    public abstract class InMemoryRepository<T> : IBaseRepository<T> where T : BaseObject
    {
        protected IList<T> _items;

        public void CreateItem(T item)
        {
            _items.Add(item);   
        }

        public IList<T> GetAll()
        {
            return _items;
        }

        public T GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }
    }
}
