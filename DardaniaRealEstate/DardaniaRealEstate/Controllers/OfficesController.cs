using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DardaniaRealEstate.Data;
using DardaniaRealEstate.Models;

namespace DardaniaRealEstate.Controllers
{
    public class OfficesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OfficesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> OfficeRent()
        {
            var applicationDbContext = _context.Office.Include(o => o.Communes);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> OfficeSell()
        {
            var applicationDbContext = _context.Office.Include(o => o.Communes);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Offices
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Office.Include(o => o.Communes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Offices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var office = await _context.Office
                .Include(o => o.Communes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (office == null)
            {
                return NotFound();
            }

            return View(office);
        }

        

        
    }
}
