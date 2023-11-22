using MotoApp.Entities;

namespace MotoApp.Repositores
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> 
        where T : class, IEntity
    {

    }
}
