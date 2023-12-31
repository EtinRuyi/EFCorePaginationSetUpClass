﻿using PaginationClass.Model;

namespace PaginationClass.Pagination.Common.Utilities
{
    public static class PaginationUtility<T>
    {
        public static async Task<PagerResponse<IEnumerable<T>>> GetPager(
            IEnumerable<T> data,
            int PerPage,
            int Page,
            Func<T, string> nameSelector,
            Func<T, string> idSelector)
        {
            PerPage = PerPage <= 0 ? 10 : PerPage;
            Page = Page <= 0 ? 1 : Page;

            data = data.OrderBy(item => nameSelector(item)).ThenBy(item => idSelector(item));
            int totalData = data.Count();
            int totalPagedCount = (int)Math.Ceiling((double)totalData / PerPage);
            var pagedData = data.Skip((Page - 1) * PerPage).Take(PerPage);

            return new PagerResponse<IEnumerable<T>>
            {
                Data = pagedData,
                TotalPageCount = totalPagedCount,
                CurrentPage = Page,
                PerPage = pagedData.Count(),
                TotalCount = totalData
            };
        }
    }
}
