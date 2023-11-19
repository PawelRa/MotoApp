using MotoApp.Entities;

namespace MotoApp.Repositores
{
    public interface IRepository<T> : IRepository<T>, IWriteRepository<T> where T : IEntity
    {

    }
}
