/*
 * @overview        {CodigoIdentificacionVialController}
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
     * TODO: Description of {@code CodigoIdentificacionVialController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class CodigoIdentificacionVialController : Controller {
        private readonly ViasContext _context;

        /**
         * TODO: Description of method {@code CodigoIdentificacionVialController}.
         *
         */
        public CodigoIdentificacionVialController(ViasContext context) {
            _context = context;
        }

        /**
         * GET: CodigoIdentificacionVial
         *
         */
        public async Task<IActionResult> Index() {
            return View(await _context.CodigoIdentificacionVial.ToListAsync());
        }

        /**
         * GET: CodigoIdentificacionVial/Details/5
         *
         */
        public async Task<IActionResult> Details(string id) {
            if (id == null || _context.CodigoIdentificacionVial == null) {
                return NotFound();
            }

            var codigoIdentificacionVial = await _context.CodigoIdentificacionVial
                .FirstOrDefaultAsync(m => m.StrCiv == id);
            if (codigoIdentificacionVial == null) {
                return NotFound();
            }

            return View(codigoIdentificacionVial);
        }

        /**
         * GET: CodigoIdentificacionVial/Create
         *
         */
        public IActionResult Create() {
            return View();
        }

        /**
         * POST: CodigoIdentificacionVial/Create
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrCiv,StrNombreEjeVia,StrNombreExtremoInicial,StrNombreExtremoFinal,StrTipoMalla")] CodigoIdentificacionVial codigoIdentificacionVial) {
            if (ModelState.IsValid) {
                _context.Add(codigoIdentificacionVial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(codigoIdentificacionVial);
        }

        /**
         * GET: CodigoIdentificacionVial/Edit/5
         *
         */
        public async Task<IActionResult> Edit(string id) {
            if (id == null || _context.CodigoIdentificacionVial == null) {
                return NotFound();
            }

            var codigoIdentificacionVial = await _context.CodigoIdentificacionVial.FindAsync(id);
            if (codigoIdentificacionVial == null) {
                return NotFound();
            }
            return View(codigoIdentificacionVial);
        }

        /**
         * POST: CodigoIdentificacionVial/Edit/5
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrCiv,StrNombreEjeVia,StrNombreExtremoInicial,StrNombreExtremoFinal,StrTipoMalla")] CodigoIdentificacionVial codigoIdentificacionVial) {
            if (id != codigoIdentificacionVial.StrCiv) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(codigoIdentificacionVial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!CodigoIdentificacionVialExists(codigoIdentificacionVial.StrCiv)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(codigoIdentificacionVial);
        }

        /**
         * GET: CodigoIdentificacionVial/Delete/5
         *
         */
        public async Task<IActionResult> Delete(string id) {
            if (id == null || _context.CodigoIdentificacionVial == null) {
                return NotFound();
            }

            var codigoIdentificacionVial = await _context.CodigoIdentificacionVial
                .FirstOrDefaultAsync(m => m.StrCiv == id);
            if (codigoIdentificacionVial == null) {
                return NotFound();
            }

            return View(codigoIdentificacionVial);
        }

        /**
         * POST: CodigoIdentificacionVial/Delete/5
         *
         */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id) {
            if (_context.CodigoIdentificacionVial == null) {
                return Problem("Entity set 'ViasContext.CodigoIdentificacionVial'  is null.");
            }
            var codigoIdentificacionVial = await _context.CodigoIdentificacionVial.FindAsync(id);
            if (codigoIdentificacionVial != null) {
                _context.CodigoIdentificacionVial.Remove(codigoIdentificacionVial);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /**
         * TODO: Description of method {@code CodigoIdentificacionVialExists}.
         *
         */
        private bool CodigoIdentificacionVialExists(string id) {
            return _context.CodigoIdentificacionVial.Any(e => e.StrCiv == id);
        }
    }
}
