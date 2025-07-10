/*
 * @overview        {ProductoController}
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
     * TODO: Description of {@code ProductoController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class ProductoController : Controller {
        private readonly ViasContext _context;

        /**
         * TODO: Description of method {@code ProductoController}.
         *
         */
        public ProductoController(ViasContext context) {
            _context = context;
        }

        /**
         * GET: Producto
         *
         */
        public async Task<IActionResult> Index() {
            return View(await _context.Producto.ToListAsync());
        }

        /**
         * GET: Producto/Details/5
         *
         */
        public async Task<IActionResult> Details(string id) {
            if (id == null || _context.Producto == null) {
                return NotFound();
            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (producto == null) {
                return NotFound();
            }

            return View(producto);
        }

        /**
         * GET: Producto/Create
         *
         */
        public IActionResult Create() {
            return View();
        }

        /**
         * POST: Producto/Create
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrCodigo,StrNombre,StrDetalles,StrTipo")] Producto producto) {
            if (ModelState.IsValid) {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        /**
         * GET: Producto/Edit/5
         *
         */
        public async Task<IActionResult> Edit(string id) {
            if (id == null || _context.Producto == null) {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null) {
                return NotFound();
            }
            return View(producto);
        }

        /**
         * POST: Producto/Edit/5
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrCodigo,StrNombre,StrDetalles,StrTipo")] Producto producto) {
            if (id != producto.StrCodigo) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!ProductoExists(producto.StrCodigo)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        /**
         * GET: Producto/Delete/5
         *
         */
        public async Task<IActionResult> Delete(string id) {
            if (id == null || _context.Producto == null) {
                return NotFound();
            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (producto == null) {
                return NotFound();
            }

            return View(producto);
        }

        /**
         * POST: Producto/Delete/5
         *
         */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id) {
            if (_context.Producto == null) {
                return Problem("Entity set 'ViasContext.Producto'  is null.");
            }
            var producto = await _context.Producto.FindAsync(id);
            if (producto != null) {
                _context.Producto.Remove(producto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /**
         * TODO: Description of method {@code ProductoExists}.
         *
         */
        private bool ProductoExists(string id) {
            return _context.Producto.Any(e => e.StrCodigo == id);
        }
    }
}
