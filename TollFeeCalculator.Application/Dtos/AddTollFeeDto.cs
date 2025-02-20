using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Application.Dtos
{
	public class AddTollFeeDto
	{
		public Guid VehicleId { get; set; }
		public Double Amount { get; set; }
		public Guid TollPassageId { get; set; }
	}
}
