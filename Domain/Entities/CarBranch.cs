﻿using System;
using Domain.Abstractions;

namespace Domain.Entities
{
	public class CarBranch: Entity
	{
		public Guid BranchId { get; set; }
		public Branch Branch { get; set; }

		public Guid CarId { get; set; }
		public Car Car { get; set; }
		public int Quantity { get; set; }


	}
}

