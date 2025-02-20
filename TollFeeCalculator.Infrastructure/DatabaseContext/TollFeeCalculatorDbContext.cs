using Microsoft.EntityFrameworkCore;
using TollFeeCalculator.Domain.Entities.Models;

namespace TollFeeCalculator.Infrastructure.DatabaseContext
{
	public class TollFeeCalculatorDbContext: DbContext
	{
		public TollFeeCalculatorDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{

		}
		public DbSet<Vehicle> Vehicles { get; set; } = null!;
		public DbSet<TollFee> TollFees { get; set; } = null!;
		public DbSet<TollPassage> TollPassages { get; set;} = null!;
	}
}
