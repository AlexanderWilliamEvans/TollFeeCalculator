using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TollFeeCalculator.Infrastructure.Repostories;

namespace TollFeeCalculator.Infrastructure.Repositories
{
	public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
	{
		protected readonly DbContext Context;
		internal DbSet<TEntity> dbSet;
		public BaseRepository(DbContext context)
		{
			Context = context;
			this.dbSet = context.Set<TEntity>();
		}
		public async Task<TEntity> Add(TEntity entity)
		{
			var _entity = Context.Set<TEntity>().Add(entity);
			await Context.SaveChangesAsync();
			return entity;
		}

		public async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
		{
			return Context.Set<TEntity>().Where(predicate);
		}

		public Task<TEntity> Get(Guid id)
		{
			throw new NotImplementedException();
		}
		public async Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, string includeProperties)
		{
			IQueryable<TEntity> query = dbSet;
			if (filter != null)
			{
				query = Context.Set<TEntity>().Where(filter);
			}
			foreach (var includeProperty in includeProperties.Split
			   (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
			{
				query = dbSet.Include(includeProperty);
			}

			if (orderBy != null)
			{
				return orderBy(query).ToList();
			}
			return await Context.Set<TEntity>().ToListAsync();

		}

		public async Task<bool> Remove(Guid id)
		{
			try
			{
				var entity = await Context.Set<TEntity>().FindAsync(id);
				if (entity != null)
				{
					Context.Set<TEntity>().Remove(entity);
					await Context.SaveChangesAsync();
					return true;
				}
			}
			catch (Exception ex)
			{
				throw new Exception();
			}
			return false;
		}

		public async Task<TEntity> Update(TEntity entity)
		{
			Context.Set<TEntity>().Update(entity);
			await Context.SaveChangesAsync();
			return entity;
		}
	}
}
