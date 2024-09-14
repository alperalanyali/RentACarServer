using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
    public class Payment:Entity
    {

        public Guid CarRequestId { get; set; }

        public CarRequest CarRequest { get; set; }

        public DateTime PaymentDate { get; set; }

        public decimal Amount { get; set; }

        public decimal TaxAmount { get; set; }

        public PaymentMethod Method { get; set; }

        public PaymentStatus Status { get; set; }


    }
}