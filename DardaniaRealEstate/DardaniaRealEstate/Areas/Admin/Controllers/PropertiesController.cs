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

namespace DardaniaRealEstate.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class PropertiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropertiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Properties
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Properties.Include(p => p.Agents).Include(p => p.Communes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Properties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = await _context.Properties
                .Include(p => p.Agents)
                .Include(p => p.Communes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (properties == null)
            {
                return NotFound();
            }

            return View(properties);
        }

        // GET: Admin/Properties/Create
        public IActionResult Create()
        {
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id");
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id");
            return View();
        }

        // POST: Admin/Properties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CommunesID,AgentsID,Location,Squaremeters,Photo,GoogleMapsLink,Sketch,Price")] Properties properties)
        {
            if (ModelState.IsValid)
            {
                _context.Add(properties);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id", properties.AgentsID);
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id", properties.CommunesID);
            return View(properties);
        }

        // GET: Admin/Properties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = await _context.Properties.FindAsync(id);
            if (properties == null)
            {
                return NotFound();
            }
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id", properties.AgentsID);
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id", properties.CommunesID);
            return View(properties);
        }

        // POST: Admin/Properties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CommunesID,AgentsID,Location,Squaremeters,Photo,GoogleMapsLink,Sketch,Price")] Properties properties)
        {
            if (id != properties.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(properties);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropertiesExists(properties.Id))
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
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id", properties.AgentsID);
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id", properties.CommunesID);
            return View(properties);
        }

        // GET: Admin/Properties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var properties = await _context.Properties
                .Include(p => p.Agents)
                .Include(p => p.Communes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (properties == null)
            {
                return NotFound();
            }

            return View(properties);
        }

        // POST: Admin/Properties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var properties = await _context.Properties.FindAsync(id);
            _context.Properties.Remove(properties);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertiesExists(int id)
        {
            return _context.Properties.Any(e => e.Id == id);
        }
    }
}
