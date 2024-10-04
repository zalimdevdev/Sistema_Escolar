using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sis_Escolar.Models;

namespace Sis_Escolar.Controllers
{
    public class TutorController : Controller
    {
        private readonly AppDbContext _context;

        public TutorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Tutor
        public async Task<IActionResult> Index()
        {
              return _context.Tutores != null ? 
                          View(await _context.Tutores.ToListAsync()) :
                          Problem("Entity set 'AppDbContext.Tutores'  is null.");
        }

        // GET: Tutor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Tutores == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutores
                .FirstOrDefaultAsync(m => m.id == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // GET: Tutor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tutor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Nombre,Apellido,Relación,Teléfono,Email")] Tutor tutor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tutor);
        }

        // GET: Tutor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Tutores == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutores.FindAsync(id);
            if (tutor == null)
            {
                return NotFound();
            }
            return View(tutor);
        }

        // POST: Tutor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Nombre,Apellido,Relación,Teléfono,Email")] Tutor tutor)
        {
            if (id != tutor.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tutor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TutorExists(tutor.id))
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
            return View(tutor);
        }

        // GET: Tutor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Tutores == null)
            {
                return NotFound();
            }

            var tutor = await _context.Tutores
                .FirstOrDefaultAsync(m => m.id == id);
            if (tutor == null)
            {
                return NotFound();
            }

            return View(tutor);
        }

        // POST: Tutor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Tutores == null)
            {
                return Problem("Entity set 'AppDbContext.Tutores'  is null.");
            }
            var tutor = await _context.Tutores.FindAsync(id);
            if (tutor != null)
            {
                _context.Tutores.Remove(tutor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TutorExists(int id)
        {
          return (_context.Tutores?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
