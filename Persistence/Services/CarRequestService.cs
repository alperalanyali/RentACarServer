﻿using System;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.CarRequestRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
	public class CarRequestService:ICarRequestService
	{
        private readonly ICarRequestCommandRepository _carRequestCommand;
        private readonly ICarRequestQueryRepository _CarRequestQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public CarRequestService(ICarRequestCommandRepository carRequestCommandRepository, ICarRequestQueryRepository carRequestQueryRepository, IAppUnitOfWork appUnitOfWork)
        {
            _carRequestCommand = carRequestCommandRepository;
            _CarRequestQuery = carRequestQueryRepository;
            _unitOfWork = appUnitOfWork;
        }
        public async Task CreateCarRequest(CarRequest carRequest, CancellationToken cancellationToken)
        {
            await _carRequestCommand.AddAsync(carRequest, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteCarRequest(Guid id,CancellationToken cancellationToken)
        {
             _carRequestCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            
        }

        public async Task<IList<CarRequest>> GetAll(string search)
        {
            var list = await _CarRequestQuery.GetAllAsync().Include(p => p.Car).ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _CarRequestQuery.GetWhere(p => !string.IsNullOrEmpty(search) && (
                p.Car.LicenseNumber.ToLower().Contains(search.ToLower())
                || p.Car.Model.ToLower().Contains(search.ToLower())
                )).Include(p => p.Car).ToListAsync();
            }
            return list;
        }

        public async Task<CarRequest> GetById(Guid id)
        {
            var carRequest = await _CarRequestQuery.GetById(id.ToString());
            return carRequest;
        }

        public async Task<IList<CarRequest>> GetCarRequestsByCarId(Guid carId)
        {
            var list = await _CarRequestQuery.GetWhere(p => p.CarId == carId).Include(p => p.Car).ToListAsync();
            return list;
        }

        public async Task<IList<CarRequest>> GetCarRequestsByUserId(Guid userId, int currentPage, int pageSize, CancellationToken cancellationToken)
        {
            var list = await _CarRequestQuery.GetWhere(p => p.UserId == userId).Include(p => p.Car).Skip((currentPage - 1)*pageSize).Take(pageSize).ToListAsync();

            return list;
        }

        public async Task UpdateCarRequest(CarRequest carRequest, CancellationToken cancellationToken)
        {
             _carRequestCommand.Update(carRequest);
             await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}

