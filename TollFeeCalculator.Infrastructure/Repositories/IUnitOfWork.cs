using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Infrastructure.Repositories
{
	public interface IUnitOfWork: IDisposable
	{
		int Complete();
	}
}
