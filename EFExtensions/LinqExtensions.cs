using System;
using System.Linq;
using System.Linq.Expressions;

namespace EFExtensions
{
    public static class LinqExtensions
    {
        public static IQueryable<TSource> WhereStartsAndEndsWith<TSource>(
            this IQueryable<TSource> source,
            Expression<Func<TSource, string>> valueSelector,
            string value)
        {
            return source.Where(BuildExpression(valueSelector, value));
        }

        public static Expression<Func<TElement, bool>> BuildExpression<TElement>(
            Expression<Func<TElement, string>> valueSelector,
            string value)
        {
            if (valueSelector == null)
                throw new ArgumentNullException("valueSelector");

            var stringType = typeof(string);
            var startsWithMethod = stringType.GetMethod("StartsWith", new[] { stringType });
            var endsWithMethod = stringType.GetMethod("EndsWith", new[] { stringType });

            var left = Expression.Call(valueSelector.Body, startsWithMethod, Expression.Constant(value));
            var right = Expression.Call(valueSelector.Body, endsWithMethod, Expression.Constant(value));

            var body = Expression.AndAlso(left, right);

            var parameter = valueSelector.Parameters.Single();
            return Expression.Lambda<Func<TElement, bool>>(body, parameter);
        }
    }
}