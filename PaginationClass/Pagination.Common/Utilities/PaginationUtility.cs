using PaginationClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginationClass.Pagination.Common.Utilities
{
    public static class PaginationUtility<T>
    {
        public static async Task<PagerResponse<IEnumerable<T>>> GetPager(IEnumerable<T> items, Pager paginationParameters)
        {
            paginationParameters.PageSize = paginationParameters.PageSize <= 0 ? 10 : paginationParameters.PageSize;
            paginationParameters.Page = paginationParameters.Page <= 0 ? 1 : paginationParameters.Page;

            int totalItems = items.Count();
            int totalPagedCount = (int)Math.Ceiling((double)totalItems / paginationParameters.PageSize);

            var pagedItems = items.Skip((paginationParameters.Page - 1) * paginationParameters.PageSize).Take(paginationParameters.PageSize);

            return new PagerResponse<IEnumerable<T>>
            {
                Data = pagedItems,
                Pages = totalPagedCount,
                CurrentPage = paginationParameters.Page,
                TotalCount = totalItems,
                TotalPagedCount = pagedItems.Count()
            };
        }
    }
}