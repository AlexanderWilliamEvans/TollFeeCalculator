using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollFeeCalculator.Infrastructure.DatabaseContext;
using TollFeeCalculator.Infrastructure.Repositories.TollFee;

namespace TollFeeCalculator.Infrastructure.Repositories
{
	public class UnitOfWork: IUnitOfWork
	{
		private readonly TollFeeCalculatorDbContext _tollFeeCalculatorDbContext;
		public ITollFeeRepository TollFeeRepository { get; set; }
		public UnitOfWork(TollFeeCalculatorDbContext tollFeeCalculatorDbContext)
		{
			_tollFeeCalculatorDbContext = tollFeeCalculatorDbContext;
			TollFeeRepository = new TollFeeRepository(_tollFeeCalculatorDbContext);
		}

		public int Complete()
		{
			return _tollFeeCalculatorDbContext.SaveChanges();
		}

		public void Dispose()
		{
			_tollFeeCalculatorDbContext.Dispose();
		}
	}
}
