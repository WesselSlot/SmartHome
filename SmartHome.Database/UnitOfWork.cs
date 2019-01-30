using Microsoft.EntityFrameworkCore;
using SmartHome.Database.Contexts;
using SmartHome.Database.Interfaces;
using SmartHome.Database.Models;

namespace SmartHome.Database
{
    public class UnitOfWork : IUnitOfWork
    {   
        public IGenericRepository<Light> _lightRepository { get; }
        
        private SmartHomeContext _smartHomeContext = new SmartHomeContext();

        public UnitOfWork()
        {
            _lightRepository = new GenericRepository<Light>(_smartHomeContext);
        }

        public IGenericRepository<Light> LightRepository => _lightRepository;

        public void SaveChanges()
        {
            SaveChanges();
        }
    }
}