﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Domain.Entities.Models
{
	public class BaseModel
	{
		public BaseModel()
		{
			Id = new Guid();
		}

		[Key]
		public Guid Id { get; set; }

		public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

		public DateTime? UpdatedOn { get; set; }
	}
}
