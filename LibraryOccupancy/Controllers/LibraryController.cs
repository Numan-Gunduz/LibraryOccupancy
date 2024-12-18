using Microsoft.AspNetCore.Mvc;
using LibraryOccupancy.Data;
using System.Linq;

namespace LibraryOccupancy.Controllers
{
    public class LibraryController : Controller
    {
        private readonly LibraryContext _context;

        public LibraryController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var library = _context.Libraries.FirstOrDefault();
            return View(library);
        }
    }
}
