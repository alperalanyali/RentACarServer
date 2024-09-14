using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Domain.Entities;
using Domain.Repositories.PaymentRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;
using Persistence.Services;

namespace Persistence.Repositories.PaymentRepository
{
    public class PaymentCommandRepository : AppCommandRepository<Payment>, IPaymentCommandRepository
    {
        public PaymentCommandRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}