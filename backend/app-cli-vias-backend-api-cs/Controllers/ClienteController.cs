﻿/*
 * @fileoverview    {ClienteController}
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
     * TODO: Description of {@code ClienteController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class ClienteController : Controller {
        private readonly ViasContext _context;

        /**
         * TODO: Description of method {@code ClienteController}.
         *
         */
        public ClienteController(ViasContext context) {
            _context = context;
        }

        /**
         * GET: Cliente
         *
         */
        public async Task<IActionResult> Index() {
            return View(await _context.Cliente.ToListAsync());
        }

        /**
         * GET: Cliente/Details/5
         *
         */
        public async Task<IActionResult> Details(string id) {
            if (id == null || _context.Cliente == null) {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(m => m.StrNit == id);
            if (cliente == null) {
                return NotFound();
            }

            return View(cliente);
        }

        /**
         * GET: Cliente/Create
         *
         */
        public IActionResult Create() {
            return View();
        }

        /**
         * POST: Cliente/Create
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrNit,StrNombre,StrDireccion,StrTelefono,StrFax,StrObservaciones")] Cliente cliente) {
            if (ModelState.IsValid) {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        /**
         * GET: Cliente/Edit/5
         *
         */
        public async Task<IActionResult> Edit(string id) {
            if (id == null || _context.Cliente == null) {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null) {
                return NotFound();
            }
            return View(cliente);
        }

        /**
         * POST: Cliente/Edit/5
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrNit,StrNombre,StrDireccion,StrTelefono,StrFax,StrObservaciones")] Cliente cliente) {
            if (id != cliente.StrNit) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!ClienteExists(cliente.StrNit)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        /**
         * GET: Cliente/Delete/5
         *
         */
        public async Task<IActionResult> Delete(string id) {
            if (id == null || _context.Cliente == null) {
                return NotFound();
            }

            var cliente = await _context.Cliente
                .FirstOrDefaultAsync(m => m.StrNit == id);
            if (cliente == null) {
                return NotFound();
            }

            return View(cliente);
        }

        /**
         * POST: Cliente/Delete/5
         *
         */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id) {
            if (_context.Cliente == null) {
                return Problem("Entity set 'ViasContext.Cliente'  is null.");
            }
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente != null) {
                _context.Cliente.Remove(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /**
         * TODO: Description of method {@code ClienteExists}.
         *
         */
        private bool ClienteExists(string id) {
            return _context.Cliente.Any(e => e.StrNit == id);
        }
    }
}
