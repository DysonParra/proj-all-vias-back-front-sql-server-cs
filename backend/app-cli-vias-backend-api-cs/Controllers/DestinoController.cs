﻿/*
 * @overview        {DestinoController}
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
     * TODO: Description of {@code DestinoController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class DestinoController : Controller {
        private readonly ViasContext _context;

        /**
         * TODO: Description of method {@code DestinoController}.
         *
         */
        public DestinoController(ViasContext context) {
            _context = context;
        }

        /**
         * GET: Destino
         *
         */
        public async Task<IActionResult> Index() {
            return View(await _context.Destino.ToListAsync());
        }

        /**
         * GET: Destino/Details/5
         *
         */
        public async Task<IActionResult> Details(string id) {
            if (id == null || _context.Destino == null) {
                return NotFound();
            }

            var destino = await _context.Destino
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (destino == null) {
                return NotFound();
            }

            return View(destino);
        }

        /**
         * GET: Destino/Create
         *
         */
        public IActionResult Create() {
            return View();
        }

        /**
         * POST: Destino/Create
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrCodigo,StrNombre,StrDetalles")] Destino destino) {
            if (ModelState.IsValid) {
                _context.Add(destino);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(destino);
        }

        /**
         * GET: Destino/Edit/5
         *
         */
        public async Task<IActionResult> Edit(string id) {
            if (id == null || _context.Destino == null) {
                return NotFound();
            }

            var destino = await _context.Destino.FindAsync(id);
            if (destino == null) {
                return NotFound();
            }
            return View(destino);
        }

        /**
         * POST: Destino/Edit/5
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrCodigo,StrNombre,StrDetalles")] Destino destino) {
            if (id != destino.StrCodigo) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(destino);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!DestinoExists(destino.StrCodigo)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(destino);
        }

        /**
         * GET: Destino/Delete/5
         *
         */
        public async Task<IActionResult> Delete(string id) {
            if (id == null || _context.Destino == null) {
                return NotFound();
            }

            var destino = await _context.Destino
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (destino == null) {
                return NotFound();
            }

            return View(destino);
        }

        /**
         * POST: Destino/Delete/5
         *
         */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id) {
            if (_context.Destino == null) {
                return Problem("Entity set 'ViasContext.Destino'  is null.");
            }
            var destino = await _context.Destino.FindAsync(id);
            if (destino != null) {
                _context.Destino.Remove(destino);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /**
         * TODO: Description of method {@code DestinoExists}.
         *
         */
        private bool DestinoExists(string id) {
            return _context.Destino.Any(e => e.StrCodigo == id);
        }
    }
}
