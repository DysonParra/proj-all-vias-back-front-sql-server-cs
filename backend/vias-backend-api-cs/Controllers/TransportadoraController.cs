/*
 * @fileoverview    {TransportadoraController}
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementación realizada.
 * @version 2.0     Documentación agregada.
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
    public class TransportadoraController : Controller
    {
        private readonly ViasContext _context;

        public TransportadoraController(ViasContext context)
        {
            _context = context;
        }

        // GET: Transportadora
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transportadora.ToListAsync());
        }

        // GET: Transportadora/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Transportadora == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadora
                .FirstOrDefaultAsync(m => m.StrNombre == id);
            if (transportadora == null)
            {
                return NotFound();
            }

            return View(transportadora);
        }

        // GET: Transportadora/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transportadora/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrNombre,StrNit,StrDireccion,StrTelefono,StrFax,StrObservaciones")] Transportadora transportadora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transportadora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transportadora);
        }

        // GET: Transportadora/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Transportadora == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadora.FindAsync(id);
            if (transportadora == null)
            {
                return NotFound();
            }
            return View(transportadora);
        }

        // POST: Transportadora/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrNombre,StrNit,StrDireccion,StrTelefono,StrFax,StrObservaciones")] Transportadora transportadora)
        {
            if (id != transportadora.StrNombre)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transportadora);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransportadoraExists(transportadora.StrNombre))
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
            return View(transportadora);
        }

        // GET: Transportadora/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Transportadora == null)
            {
                return NotFound();
            }

            var transportadora = await _context.Transportadora
                .FirstOrDefaultAsync(m => m.StrNombre == id);
            if (transportadora == null)
            {
                return NotFound();
            }

            return View(transportadora);
        }

        // POST: Transportadora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Transportadora == null)
            {
                return Problem("Entity set 'ViasContext.Transportadora'  is null.");
            }
            var transportadora = await _context.Transportadora.FindAsync(id);
            if (transportadora != null)
            {
                _context.Transportadora.Remove(transportadora);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransportadoraExists(string id)
        {
            return _context.Transportadora.Any(e => e.StrNombre == id);
        }
    }
}
