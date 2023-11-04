using MotoApp.Entities;

namespace MotoApp.Repositores
{
    public class GenericRepository<TEntity, TKey>
        where TEntity : IEntity
    {
        public TKey? Key { get; set; }

        protected readonly List<TEntity> _items = new();

        public void Add(TEntity item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public TEntity GetByID(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
