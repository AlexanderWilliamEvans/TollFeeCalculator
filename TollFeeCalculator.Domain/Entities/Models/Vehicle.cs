using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator.Domain.Entities.Models;

namespace TollFeeCalculator.Domain.Entities.Models
{
	public class Vehicle: BaseModel
	{
		[Required]
		public string LicensePlate { get; set; } = string.Empty;

		[Required]
		[AllowedValues("Car", "Motorbike", "Bus")]
		public string TypeOfVehicle { get; set; } = string.Empty;

		public ICollection<TollPassage> TollPassages { get; set; } = new List<TollPassage>();
	}
}
