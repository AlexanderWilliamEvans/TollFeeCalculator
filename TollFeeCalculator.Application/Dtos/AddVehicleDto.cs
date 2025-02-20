using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Application.Dtos
{
	public class AddVehicleDto
	{
		[Required]
		public string LicensePlate { get; set; } = string.Empty;

		[Required]
		[AllowedValues("Car", "Motorbike", "Bus")]
		public string TypeOfVehicle { get; set; } = string.Empty;
	}
}
