using SmartHome.Database.Models;

namespace SmartHome.Database.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Light> LightRepository { get; }
        void SaveChanges();
    }
}