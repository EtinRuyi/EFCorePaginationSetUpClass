using PaginationClass.Model;

namespace PaginationClass.Pagination.Common.Utilities
{
    public static class PaginationUtility<T>
    {
        public static async Task<PagerResponse<IEnumerable<T>>> GetPager(
            IEnumerable<T> data,
            int PerPage,
            int Pages,
            Func<T, string> nameSelector,
            Func<T, string> idSelector)
        {
            PerPage = PerPage <= 0 ? 10 : PerPage;
            Pages = Pages <= 0 ? 1 : Pages;

            data = data.OrderBy(item => nameSelector(item)).ThenBy(item => idSelector(item));
            int totalData = data.Count();
            int totalPagedCount = (int)Math.Ceiling((double)totalData / PerPage);
            var pagedData = data.Skip((Pages - 1) * PerPage).Take(PerPage);

            return new PagerResponse<IEnumerable<T>>
            {
                Data = pagedData,
                TotalPageCount = totalPagedCount,
                CurrentPage = Pages,
                PerPage = pagedData.Count(),
                TotalCount = totalData
            };
        }
    }
}
