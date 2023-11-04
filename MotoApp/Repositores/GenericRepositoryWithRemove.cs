using MotoApp.Entities;

namespace MotoApp.Repositores
{
    public class GenericRepositoryWithRemove<T, TKey> : GenericRepository<T, TKey> where T : IEntity
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
