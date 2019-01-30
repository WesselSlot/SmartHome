using System;


using SmartHome.Database.Interfaces;

namespace SmartHome.Core.Services
{
    public class LightManagerService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public LightManagerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public void TurnOnLight(Guid lightId)
        {
            var light = _unitOfWork.LightRepository.SingleOrDefault(x => x.Id == lightId);

            light.Status = true;

            _unitOfWork.SaveChanges();
        }
    }
}