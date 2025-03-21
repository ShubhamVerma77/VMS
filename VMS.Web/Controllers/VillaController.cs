using Microsoft.AspNetCore.Mvc;
using VMS.Domain.Entities;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa villa)
        {
            if (villa.Name == villa.Description)
            {
                ModelState.AddModelError("description", "Name And Description Are Not Exactly Same");
            }
            if (ModelState.IsValid)
            {
                _context.Add(villa);
                _context.SaveChanges();
                TempData["success"] = "Data Has Been Created Successfully";

                return RedirectToAction("Index");
            }
            TempData["error"] = "Error Occured";
            return View();
       
        }
        public IActionResult Edit (int Villaid)
        {
            Villa? Data = _context.Villas.FirstOrDefault(u=>u.ID==Villaid);
            if(Data == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(Data);
        }

        [HttpPost]
        public IActionResult Edit(Villa villa)
        {
            if(ModelState.IsValid)
            {
                _context.Update(villa);
                _context.SaveChanges();
                TempData["success"] = "Data Has Been Updated Successfully";

                return RedirectToAction("Index");
            }
            TempData["error"] = "Error Occured";
            return View();
        

        }

        public IActionResult Delete(int Villaid)
        {
            Villa? data = _context.Villas.FirstOrDefault(v => v.ID==Villaid);
            if (data == null)
            {
                return RedirectToAction("Error", "Home");
            }
          return View(data) ;
        }

        [HttpPost]
        public IActionResult Delete(Villa villa)
        {
            Villa? delvilla = _context.Villas.FirstOrDefault(u => u.ID == villa.ID);
            if(delvilla is not null)
            {
                _context.Remove(delvilla);
                _context.SaveChanges();
                TempData["success"] = "Data Has Been Deleted Successfully";
                return RedirectToAction("Index");

            }
            TempData["error"] = "Error Occured";
            return View();
        }
    }
}
