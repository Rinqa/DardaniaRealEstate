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
    public class CommunesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CommunesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Communes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Communes.ToListAsync());
        }

        // GET: Admin/Communes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communes = await _context.Communes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (communes == null)
            {
                return NotFound();
            }

            return View(communes);
        }

        // GET: Admin/Communes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Communes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Communes communes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(communes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(communes);
        }

        // GET: Admin/Communes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communes = await _context.Communes.FindAsync(id);
            if (communes == null)
            {
                return NotFound();
            }
            return View(communes);
        }

        // POST: Admin/Communes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Communes communes)
        {
            if (id != communes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(communes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommunesExists(communes.Id))
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
            return View(communes);
        }

        // GET: Admin/Communes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var communes = await _context.Communes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (communes == null)
            {
                return NotFound();
            }

            return View(communes);
        }

        // POST: Admin/Communes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var communes = await _context.Communes.FindAsync(id);
            _context.Communes.Remove(communes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommunesExists(int id)
        {
            return _context.Communes.Any(e => e.Id == id);
        }
    }
}
