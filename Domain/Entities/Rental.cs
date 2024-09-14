using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Rental
    {
        public Guid Id  { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid CarBranchId { get; set; }
        public CarBranch CarBranch { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public int Duration { get; set; }

        public decimal TotalPrice { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}