using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Domain.Entities.Models
{
	public class TollFee: BaseModel
	{
		public double Amount { get; set; }
		public Guid VehicleId { get; set; }
		public required Vehicle Vehicle { get; set; }
		public Guid TollPassageId { get; set; }
		public required TollPassage TollPassage { get; set; }
	}
}
