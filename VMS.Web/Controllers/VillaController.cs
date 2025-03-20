using Microsoft.AspNetCore.Mvc;
using VMS.Infrastructure.Data;

namespace VMS.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public VillaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Villas.ToList();
            return View(data);
        }
    }
}
