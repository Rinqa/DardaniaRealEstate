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
    public class ResController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Res
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Residence.Include(r => r.Agents).Include(r => r.Communes);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/Res/Details/5
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

        // GET: Admin/Res/Create
        public IActionResult Create()
        {
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id");
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id");
            return View();
        }

        // POST: Admin/Res/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Photo,Warehouse,GardenSpace,ResidenceSpace,Address,Garage,Floors,CityDistance,RoomNumber,SleepingRoom,Bathrooms,BuildingType,CommunesID,AgentsID,ConstructionYear,Description,Options,Price,GoogleMapsLink")] Residence residence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(residence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id", residence.AgentsID);
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id", residence.CommunesID);
            return View(residence);
        }

        // GET: Admin/Res/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residence = await _context.Residence.FindAsync(id);
            if (residence == null)
            {
                return NotFound();
            }
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id", residence.AgentsID);
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id", residence.CommunesID);
            return View(residence);
        }

        // POST: Admin/Res/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Photo,Warehouse,GardenSpace,ResidenceSpace,Address,Garage,Floors,CityDistance,RoomNumber,SleepingRoom,Bathrooms,BuildingType,CommunesID,AgentsID,ConstructionYear,Description,Options,Price,GoogleMapsLink")] Residence residence)
        {
            if (id != residence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(residence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidenceExists(residence.Id))
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
            ViewData["AgentsID"] = new SelectList(_context.Agents, "Id", "Id", residence.AgentsID);
            ViewData["CommunesID"] = new SelectList(_context.Communes, "Id", "Id", residence.CommunesID);
            return View(residence);
        }

        // GET: Admin/Res/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Admin/Res/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var residence = await _context.Residence.FindAsync(id);
            _context.Residence.Remove(residence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResidenceExists(int id)
        {
            return _context.Residence.Any(e => e.Id == id);
        }
    }
}
