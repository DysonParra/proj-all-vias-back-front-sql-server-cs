/*
 * @fileoverview    {AyudanteController}
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

namespace Vias.Controllers {

    /**
     * TODO: Description of {@code AyudanteController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class AyudanteController : Controller {
        private readonly ViasContext _context;

        /**
         * TODO: Description of method {@code AyudanteController}.
         *
         */
        public AyudanteController(ViasContext context) {
            _context = context;
        }

        /**
         * GET: Ayudante
         *
         */
        public async Task<IActionResult> Index() {
            return View(await _context.Ayudante.ToListAsync());
        }

        /**
         * GET: Ayudante/Details/5
         *
         */
        public async Task<IActionResult> Details(int? id) {
            if (id == null || _context.Ayudante == null) {
                return NotFound();
            }

            var ayudante = await _context.Ayudante
                .FirstOrDefaultAsync(m => m.IntCedula == id);
            if (ayudante == null) {
                return NotFound();
            }

            return View(ayudante);
        }

        /**
         * GET: Ayudante/Create
         *
         */
        public IActionResult Create() {
            return View();
        }

        /**
         * POST: Ayudante/Create
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IntCedula,StrNombre,StrEstado")] Ayudante ayudante) {
            if (ModelState.IsValid) {
                _context.Add(ayudante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ayudante);
        }

        /**
         * GET: Ayudante/Edit/5
         *
         */
        public async Task<IActionResult> Edit(int? id) {
            if (id == null || _context.Ayudante == null) {
                return NotFound();
            }

            var ayudante = await _context.Ayudante.FindAsync(id);
            if (ayudante == null) {
                return NotFound();
            }
            return View(ayudante);
        }

        /**
         * POST: Ayudante/Edit/5
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("IntCedula,StrNombre,StrEstado")] Ayudante ayudante) {
            if (id != ayudante.IntCedula) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(ayudante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!AyudanteExists(ayudante.IntCedula)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ayudante);
        }

        /**
         * GET: Ayudante/Delete/5
         *
         */
        public async Task<IActionResult> Delete(int? id) {
            if (id == null || _context.Ayudante == null) {
                return NotFound();
            }

            var ayudante = await _context.Ayudante
                .FirstOrDefaultAsync(m => m.IntCedula == id);
            if (ayudante == null) {
                return NotFound();
            }

            return View(ayudante);
        }

        /**
         * POST: Ayudante/Delete/5
         *
         */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id) {
            if (_context.Ayudante == null) {
                return Problem("Entity set 'ViasContext.Ayudante'  is null.");
            }
            var ayudante = await _context.Ayudante.FindAsync(id);
            if (ayudante != null) {
                _context.Ayudante.Remove(ayudante);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /**
         * TODO: Description of method {@code AyudanteExists}.
         *
         */
        private bool AyudanteExists(int? id) {
            return _context.Ayudante.Any(e => e.IntCedula == id);
        }
    }
}
