using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Application.Common.Interfaces
{
	public interface IApplicationSettings
	{
		string App { get; set; }
		string AppFlavor { get; set; }
		string AppFlavorSubscript { get; set; }
		string ApplicationUrl { get; set; }
		string AppName { get; set; }
		string Company { get; set; }
		string Copyright { get; set; }
		string Version { get; set; }
	}
}
