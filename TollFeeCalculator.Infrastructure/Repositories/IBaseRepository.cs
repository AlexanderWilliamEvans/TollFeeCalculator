using System.Linq.Expressions;

namespace TollFeeCalculator.Infrastructure.Repostories
{
	public interface IBaseRepository<TEntity> where TEntity : class
	{
		Task<TEntity> Get(Guid id);
		Task<TEntity> Update(TEntity entity);
		Task<TEntity> Add(TEntity entity);
		Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
		Task <IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, string includeProperties);
		Task <bool> Remove(Guid id);

	}
}
