﻿/*
 * @fileoverview    {ProveedorController}
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
     * TODO: Description of {@code ProveedorController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class ProveedorController : Controller {
        private readonly ViasContext _context;

        public ProveedorController(ViasContext context) {
            _context = context;
        }

        // GET: Proveedor
        public async Task<IActionResult> Index() {
            return View(await _context.Proveedor.ToListAsync());
        }

        // GET: Proveedor/Details/5
        public async Task<IActionResult> Details(string id) {
            if (id == null || _context.Proveedor == null) {
                return NotFound();
            }

            var proveedor = await _context.Proveedor
                .FirstOrDefaultAsync(m => m.StrNit == id);
            if (proveedor == null) {
                return NotFound();
            }

            return View(proveedor);
        }

        // GET: Proveedor/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Proveedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrNit,StrNombre,StrDireccion,StrTelefono,StrFax,StrObservaciones")] Proveedor proveedor) {
            if (ModelState.IsValid) {
                _context.Add(proveedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proveedor);
        }

        // GET: Proveedor/Edit/5
        public async Task<IActionResult> Edit(string id) {
            if (id == null || _context.Proveedor == null) {
                return NotFound();
            }

            var proveedor = await _context.Proveedor.FindAsync(id);
            if (proveedor == null) {
                return NotFound();
            }
            return View(proveedor);
        }

        // POST: Proveedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrNit,StrNombre,StrDireccion,StrTelefono,StrFax,StrObservaciones")] Proveedor proveedor) {
            if (id != proveedor.StrNit) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(proveedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!ProveedorExists(proveedor.StrNit)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(proveedor);
        }

        // GET: Proveedor/Delete/5
        public async Task<IActionResult> Delete(string id) {
            if (id == null || _context.Proveedor == null) {
                return NotFound();
            }

            var proveedor = await _context.Proveedor
                .FirstOrDefaultAsync(m => m.StrNit == id);
            if (proveedor == null) {
                return NotFound();
            }

            return View(proveedor);
        }

        // POST: Proveedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id) {
            if (_context.Proveedor == null) {
                return Problem("Entity set 'ViasContext.Proveedor'  is null.");
            }
            var proveedor = await _context.Proveedor.FindAsync(id);
            if (proveedor != null) {
                _context.Proveedor.Remove(proveedor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProveedorExists(string id) {
            return _context.Proveedor.Any(e => e.StrNit == id);
        }
    }
}
