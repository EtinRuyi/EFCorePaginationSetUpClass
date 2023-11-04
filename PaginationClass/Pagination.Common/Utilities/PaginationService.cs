using Microsoft.AspNetCore.Mvc.RazorPages;
using PaginationClass.Model;

namespace PaginationClass.Pagination.Common.Utilities
{
    public class PaginationService<T> : IPaginationService<T>
    {
        public async Task<IEnumerable<T>> GetPager(IEnumerable<T> items, Pager paginationParameters)
        {
            paginationParameters.PageSize = paginationParameters.PageSize <= 0 ? 10 : paginationParameters.PageSize;
            paginationParameters.Page = paginationParameters.Page <= 0 ? 1 : paginationParameters.Page;
            paginationParameters.TotalItems = items.Count();
            paginationParameters.TotalPages = (int)Math.Ceiling((double)paginationParameters.TotalItems / paginationParameters.PageSize);

            return items.Skip((paginationParameters.Page - 1) * paginationParameters.PageSize).Take(paginationParameters.PageSize);
        }
    }
}
