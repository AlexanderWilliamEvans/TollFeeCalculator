using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Domain.Entities.Models
{
	public class TollPassage: BaseModel
	{
	
		[Required]
		public string Name { get; set; } = null!;
		[Required]
		public DateTime Time { get; set; }
		
		public ICollection<TollFee> TollFees { get; set; } = new List<TollFee>();
	}
}
