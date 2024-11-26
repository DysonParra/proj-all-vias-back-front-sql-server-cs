/*
 * @fileoverview    {PlantaController}
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementation done.
 * @version 2.0     Documentation added.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using Vias.Data;

namespace Vias.Controllers
{
    public class PlantaController : Controller
    {
        private readonly ViasContext _context;

        public PlantaController(ViasContext context)
        {
            _context = context;
        }

        // GET: Planta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Planta.ToListAsync());
        }

        // GET: Planta/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Planta == null)
            {
                return NotFound();
            }

            var planta = await _context.Planta
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (planta == null)
            {
                return NotFound();
            }

            return View(planta);
        }

        // GET: Planta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Planta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrCodigo,StrNombre,StrDetalles")] Planta planta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planta);
        }

        // GET: Planta/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Planta == null)
            {
                return NotFound();
            }

            var planta = await _context.Planta.FindAsync(id);
            if (planta == null)
            {
                return NotFound();
            }
            return View(planta);
        }

        // POST: Planta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrCodigo,StrNombre,StrDetalles")] Planta planta)
        {
            if (id != planta.StrCodigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlantaExists(planta.StrCodigo))
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
            return View(planta);
        }

        // GET: Planta/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Planta == null)
            {
                return NotFound();
            }

            var planta = await _context.Planta
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (planta == null)
            {
                return NotFound();
            }

            return View(planta);
        }

        // POST: Planta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Planta == null)
            {
                return Problem("Entity set 'ViasContext.Planta'  is null.");
            }
            var planta = await _context.Planta.FindAsync(id);
            if (planta != null)
            {
                _context.Planta.Remove(planta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlantaExists(string id)
        {
            return _context.Planta.Any(e => e.StrCodigo == id);
        }
    }
}
