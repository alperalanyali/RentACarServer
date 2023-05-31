using System;
using System.Collections.Generic;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.CarBranchRepository;
using Domain.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Services
{
    public class CarBranchService : ICarBranchService
    {
        private readonly ICarBranchCommandRepository _carBranchCommand;
        private readonly ICarBranchQueryRepository _carBranchQuery;
        private readonly IAppUnitOfWork _unitOfWork;

        public CarBranchService(ICarBranchCommandRepository carBranchCommandRepository, ICarBranchQueryRepository carBranchQueryRepository, IAppUnitOfWork appUnitOf)
        {
            _carBranchCommand = carBranchCommandRepository;
            _carBranchQuery = carBranchQueryRepository;
            _unitOfWork = appUnitOf;
        }
        public async Task CreateCarBranch(CarBranch carBranch, CancellationToken cancellationToken)
        {
            await _carBranchCommand.AddAsync(carBranch, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteById(Guid id,CancellationToken cancellationToken)
        {
            await _carBranchCommand.RemoveById(id);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<CarBranch>> GetAll(string search)
        {
            var list = await _carBranchQuery.GetAllAsync().Include(p => p.Branch).ThenInclude
                (p => p.Company).Include(p => p.Car).ToListAsync();
            if (!string.IsNullOrEmpty(search))
            {
                list = await _carBranchQuery.GetWhere(p => !string.IsNullOrEmpty(search) && (
                    p.Car.LicenseNumber.ToLower().Contains(search.ToLower()) || p.Car.Color.ToLower().Contains(search.ToLower())
                    || p.Car.Model.ToLower().Contains(search.ToLower())
                )).Include(p => p.Branch).ThenInclude
                (p => p.Company).Include(p => p.Car).ToListAsync();
            }
                
        
            return list;
        }

        public Task<CarBranch> GetById(Guid id)
        {
            return _carBranchQuery.GetById(id.ToString());
        }

        public async Task<IList<CarBranch>> GetCarBranchesByBranchId(Guid branchId)
        {
            var list = await _carBranchQuery.GetWhere(p => p.BranchId == branchId).Include(p => p.Car).Include(p => p.Branch).ToListAsync();
            return list;
        }

        public async Task<IList<CarBranch>> GetCarBranchesByCarId(Guid carId)
        {
            var list = await _carBranchQuery.GetWhere(p => p.CarId == carId).Include(p => p.Car).Include(p => p.Branch).ToListAsync();
            return list;
        }

        public async Task UpdateAsync(CarBranch carBranch, CancellationToken cancellationToken)
        {
            _carBranchCommand.Update(carBranch);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

        }
    }
}

