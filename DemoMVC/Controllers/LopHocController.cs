using DemoMVC.Data;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC.Controllers
{
    public class LopHocController : Controller

    {
        //khai bao application de lam viec voi CSDL
        private readonly ApplicationDbContext _context;
        public LopHocController(ApplicationDbContext context)
        {
            _context = context;
        }
        //trả về View 1 list dữ liệu  trong CSDL
        public async Task<IActionResult> Index()
        {
            return View(await _context.LopHocs.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(LopHoc lopHoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lopHoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lopHoc = await _context.LopHocs.FindAsync(id);
            if (lopHoc == null)
            {
                return NotFound();
            }
            return View(lopHoc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, LopHoc lopHoc)
        {
            if (id != lopHoc.TenLop)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lopHoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LophocExists(lopHoc.TenLop))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lopHoc);
        }

        private bool LophocExists(string tenLop)
        {
            throw new NotImplementedException();
        }
    }
}











