using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollFeeCalculator.Infrastructure.Repositories.TollFee
{
	public class TollFeeRepository: ITollFeeRepository
	{
		private DbContext _dbContext;
		public TollFeeRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}
	}
}
