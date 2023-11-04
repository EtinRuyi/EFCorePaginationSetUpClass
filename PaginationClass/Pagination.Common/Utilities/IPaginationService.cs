using Microsoft.AspNetCore.Mvc.RazorPages;
using PaginationClass.Model;

namespace PaginationClass.Pagination.Common.Utilities
{
    public interface IPaginationService<T>
    {
        Task<IEnumerable<T>> GetPager(IEnumerable<T> items, Pager paginationParameters);
    }
}