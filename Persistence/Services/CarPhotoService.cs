using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.CarPhotoRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class CarPhotoService : ICarPhotoService
    {
        private readonly ICarPhotoCommandRepository _carPhotoCommand;
        private readonly ICarPhotoQueryRepository _carPhotoQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public CarPhotoService(ICarPhotoCommandRepository carPhotoCommandRepository, ICarPhotoQueryRepository carPhotoQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _carPhotoCommand = carPhotoCommandRepository;
            _carPhotoQuery = carPhotoQueryRepository;
            _unitOfWork = appUnitOfWork;
        }

        public async Task CreateAsync(CarPhoto carPhoto, CancellationToken cancellationToken)
        {
            await _carPhotoCommand.AddAsync(carPhoto, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(Guid id, CancellationToken cancellationToken)
        {
            await _carPhotoCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<CarPhoto>> GetAllCarPhotos(string search)
        {
            var list = await _carPhotoQuery.GetAllAsync().ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                    list = await _carPhotoQuery.GetWhere(p => !string.IsNullOrEmpty(search) && (p.Car.LicenseNumber.ToLower().Contains(search.ToLower())
                        || (p.Car.Model.ToLower().Contains(search.ToLower()))
                     )).Include(p => p.Car).ToListAsync();
            }            
            return list;
        }

        public async Task<CarPhoto> GetById(Guid id)
        {
            return await _carPhotoQuery.GetById(id.ToString());
        }

        public async Task<IList<CarPhoto>> GetCarPhotosByCarId(Guid carPhotoId)
        {
            return await _carPhotoQuery.GetWhere(p => p.CarId == carPhotoId).ToListAsync();
        }

        public async Task UpdateAsync(CarPhoto carPhoto, CancellationToken cancellationToken)
        {
            _carPhotoCommand.Update(carPhoto);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

