using System;
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

        public async Task<IList<CarBranch>> GetAll(string search)
        {

            var list = await _carBranchQuery.GetAllAsync().ToListAsync();
            return  list;
        }

        public Task<CarBranch> GetById(Guid id)
        {
            return _carBranchQuery.GetById(id.ToString());
        }

        public async Task UpdateAsync(CarBranch carBranch, CancellationToken cancellationToken)
        {
            _carBranchCommand.Update(carBranch);
            await _unitOfWork.SaveChangesAsync(cancellationToken);

        }
    }
}

