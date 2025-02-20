using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using TollFeeCalculator.Infrastructure.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using TollFeeCalculator.Application.Identity;
using TollFeeCalculator.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace TollFeeCalculator.Infrastructure
{
	public static class DependencyInjection
	{
		private const string IDENTITY_SETTINGS_KEY = "IdentitySettings";
		private const string DATABASE_SETTINGS_KEY = "DatabaseSettings";
		private const string MSSQL_MIGRATIONS_ASSEMBLY = "CleanArchitecture.Blazor.Migrators.MSSQL";
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSettings(configuration).AddDatabase(configuration);

			services.AddServices();
			return services;
		}
		private static IServiceCollection AddSettings(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<IdentitySettings>(configuration.GetSection(IDENTITY_SETTINGS_KEY))
			.AddSingleton(s => s.GetRequiredService<IOptions<IdentitySettings>>().Value)
			.AddSingleton<IIdentitySettings>(s => s.GetRequiredService<IOptions<IdentitySettings>>().Value);

			services.Configure<DatabaseSettings>(configuration.GetSection(DATABASE_SETTINGS_KEY))
		  .AddSingleton(s => s.GetRequiredService<IOptions<DatabaseSettings>>().Value);
			return services;
		}

		private static IServiceCollection AddDatabase(this IServiceCollection services,
	  IConfiguration configuration)
		{
			services.AddDbContext<TollFeeCalculatorDbContext>((p, m) =>
			{
				var databaseSettings = p.GetRequiredService<IOptions<DatabaseSettings>>().Value;
				m.AddInterceptors(p.GetServices<ISaveChangesInterceptor>());
				m.UseDatabase(databaseSettings.ConnectionString);
			});
			return services;
		}
		private static DbContextOptionsBuilder UseDatabase(this DbContextOptionsBuilder builder,
	   string connectionString)
		{
					return builder.UseSqlServer(connectionString,
						e => e.MigrationsAssembly(MSSQL_MIGRATIONS_ASSEMBLY));

		}
		private static IServiceCollection AddServices(this IServiceCollection services)
		{
			return services;
		}

	}
}
