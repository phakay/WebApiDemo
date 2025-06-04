namespace WebApplicationDemo.API.Core.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        public T GetById(int id);
        public IList<T> GetAll();
        public void CreateItem(T item);
    }
}
