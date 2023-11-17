using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApplicationCore
{
    public static class IQueryableExtension
    {
        public static Task<PaginatedList<T>> ToPaginatedListAsync<T>(this IQueryable<T> queryable, int pageNumber, int pageSize)
        {
            return PaginatedList<T>.CreateAsync(queryable, pageNumber, pageSize);
        }

        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate)
        {
            if (!condition)
            {
                return query;
            }

            return query.Where(predicate);
        }
    }
}
