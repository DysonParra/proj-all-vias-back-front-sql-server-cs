/*
 * @fileoverview    {ConfiguracionController}
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
     * TODO: Description of {@code ConfiguracionController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class ConfiguracionController : Controller {
        private readonly ViasContext _context;

        /**
         * TODO: Description of method {@code ConfiguracionController}.
         *
         */
        public ConfiguracionController(ViasContext context) {
            _context = context;
        }

        /**
         * GET: Configuracion
         *
         */
        public async Task<IActionResult> Index() {
            return View(await _context.Configuracion.ToListAsync());
        }

        /**
         * GET: Configuracion/Details/5
         *
         */
        public async Task<IActionResult> Details(string id) {
            if (id == null || _context.Configuracion == null) {
                return NotFound();
            }

            var configuracion = await _context.Configuracion
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (configuracion == null) {
                return NotFound();
            }

            return View(configuracion);
        }

        /**
         * GET: Configuracion/Create
         *
         */
        public IActionResult Create() {
            return View();
        }

        /**
         * POST: Configuracion/Create
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrCodigo,StrParametro,StrValor")] Configuracion configuracion) {
            if (ModelState.IsValid) {
                _context.Add(configuracion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(configuracion);
        }

        /**
         * GET: Configuracion/Edit/5
         *
         */
        public async Task<IActionResult> Edit(string id) {
            if (id == null || _context.Configuracion == null) {
                return NotFound();
            }

            var configuracion = await _context.Configuracion.FindAsync(id);
            if (configuracion == null) {
                return NotFound();
            }
            return View(configuracion);
        }

        /**
         * POST: Configuracion/Edit/5
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrCodigo,StrParametro,StrValor")] Configuracion configuracion) {
            if (id != configuracion.StrCodigo) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(configuracion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!ConfiguracionExists(configuracion.StrCodigo)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(configuracion);
        }

        /**
         * GET: Configuracion/Delete/5
         *
         */
        public async Task<IActionResult> Delete(string id) {
            if (id == null || _context.Configuracion == null) {
                return NotFound();
            }

            var configuracion = await _context.Configuracion
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (configuracion == null) {
                return NotFound();
            }

            return View(configuracion);
        }

        /**
         * POST: Configuracion/Delete/5
         *
         */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id) {
            if (_context.Configuracion == null) {
                return Problem("Entity set 'ViasContext.Configuracion'  is null.");
            }
            var configuracion = await _context.Configuracion.FindAsync(id);
            if (configuracion != null) {
                _context.Configuracion.Remove(configuracion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /**
         * TODO: Description of method {@code ConfiguracionExists}.
         *
         */
        private bool ConfiguracionExists(string id) {
            return _context.Configuracion.Any(e => e.StrCodigo == id);
        }
    }
}
