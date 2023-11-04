using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaginationClass.Data;
using PaginationClass.Model;
using PaginationClass.Pagination.Common.Utilities;

namespace PaginationClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly PaginationDbContext _context;
        private readonly DatabaseSeeder _seeder;

        public ItemsController(PaginationDbContext context, DatabaseSeeder seeder)
        {
            _context = context;
            _seeder = seeder;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems([FromQuery] int PerPage, [FromQuery] int Page)
        {
            _seeder.Seed();

            var items = _context.Items.ToList();
            var paginatedItems = await PaginationUtility<Items>.GetPager(
                items,
                PerPage,
                Page,
                item => item.Name,
                item => item.Id
            );

            return Ok(paginatedItems);
        }


    }
}
