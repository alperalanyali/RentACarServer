using System;
using Application.Features.CarFeatures.Commands.CreateCar;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories.CarRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class CarService : ICarService
    {
        private readonly ICarCommandRepository _carCommand;
        private readonly ICarQueryRepository _carQuery;
        private readonly IAppUnitOfWork _unitOfWork;
        

        public CarService(ICarCommandRepository carCommandRepository, ICarQueryRepository carQuery,IAppUnitOfWork unitOfWork)
        {
            _carCommand = carCommandRepository;
            _carQuery = carQuery;
            _unitOfWork = unitOfWork;
        }
        public async Task CreateCarAsync(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var car = new Car(request.LicenseNumber, request.Model, request.ManufacturedDate, request.Color);
            await _carCommand.AddAsync(car, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<Car> GetById(Guid id)
        {
            return await _carQuery.GetById(id.ToString());
        }

        public async Task<IList<Car>> GetList(string search)
        {
            return await _carQuery.GetWhere(p => (!string.IsNullOrEmpty(search) && (p.Model.ToLower().Contains(search.ToLower()
                )))).ToListAsync();
        }

        public async Task UpdateCarAsync(Car car, CancellationToken cancellationToken)
        {
            _carCommand.Update(car);
            _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

