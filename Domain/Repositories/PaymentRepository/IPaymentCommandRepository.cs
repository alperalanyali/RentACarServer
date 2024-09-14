using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories.AppDbContext;

namespace Domain.Repositories.PaymentRepository
{
    public interface IPaymentCommandRepository:IAppCommandRepository<Payment>
    {
        
    }
}