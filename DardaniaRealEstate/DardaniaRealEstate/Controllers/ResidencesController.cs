using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DardaniaRealEstate.Data;
using DardaniaRealEstate.Models;
using Microsoft.AspNetCore.Authorization;

namespace DardaniaRealEstate.Controllers
{
    
    public class ResidencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResidencesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Sort()
        {

            var applicationDbContext = _context.Residence.Include(r => r.Agents).Include(r => r.Communes);
            return View(await applicationDbContext.ToListAsync());


        }

        public async Task<IActionResult> ResSell()
        {

            var applicationDbContext = _context.Residence.Include(r => r.Agents).Include(r => r.Communes);
            return View(await applicationDbContext.ToListAsync());


        }
        public async Task<IActionResult> ResRent()
        {

            var applicationDbContext = _context.Residence.Include(r => r.Agents).Include(r => r.Communes);
            return View(await applicationDbContext.ToListAsync());


        }
        // GET: Residences
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Residence.Include(r => r.Agents).Include(r => r.Communes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Residences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residence = await _context.Residence
                .Include(r => r.Agents)
                .Include(r => r.Communes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residence == null)
            {
                return NotFound();
            }

            return View(residence);
        }

    }
}
