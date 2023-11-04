using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaginationClass.Data; // Add using statement for your database context
using PaginationClass.Model;
using PaginationClass.Pagination.Common.Utilities;

namespace PaginationClass.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly PaginationDbContext _context;
        private readonly IPaginationService<Items> _paginationService;
        private readonly DatabaseSeeder _seeder;

        public ItemsController(PaginationDbContext context, IPaginationService<Items> paginationService, DatabaseSeeder seeder)
        {
            _context = context;
            _paginationService = paginationService;
            _seeder = seeder;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems([FromQuery] Pager paginationParameters)
        {
            _seeder.Seed(); // Seed the database with dummy data

            var items = _context.Items.ToList();
            var paginatedItems = await _paginationService.GetPager(items, paginationParameters);

            return Ok(paginatedItems);
        }
    }
}
