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
    public class PropertiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropertiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Properties
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Properties.Include(p => p.Agents).Include(p => p.Communes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Properties/Details/5
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

        // GET: Properties/Create
        public IActionResult Create()
        {
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id");
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id");
            return View();
        }

        // POST: Properties/Create
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

        // GET: Properties/Edit/5
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

        // POST: Properties/Edit/5
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

        // GET: Properties/Delete/5
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

        // POST: Properties/Delete/5
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
