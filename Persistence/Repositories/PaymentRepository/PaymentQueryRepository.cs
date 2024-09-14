using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories.PaymentRepository;
using Persistence.Context;
using Persistence.Repositories.GenericRepositories;

namespace Persistence.Repositories.PaymentRepository
{
    public class PaymentQueryRepository : AppGenericQueryRepository<Payment>, IPaymentQueryRepository
    {
        public PaymentQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}