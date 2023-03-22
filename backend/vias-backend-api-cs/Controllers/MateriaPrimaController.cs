/*
 * @fileoverview    {MateriaPrimaController}
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
    public class MateriaPrimaController : Controller
    {
        private readonly ViasContext _context;

        public MateriaPrimaController(ViasContext context)
        {
            _context = context;
        }

        // GET: MateriaPrima
        public async Task<IActionResult> Index()
        {
            return View(await _context.MateriaPrima.ToListAsync());
        }

        // GET: MateriaPrima/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.MateriaPrima == null)
            {
                return NotFound();
            }

            var materiaPrima = await _context.MateriaPrima
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (materiaPrima == null)
            {
                return NotFound();
            }

            return View(materiaPrima);
        }

        // GET: MateriaPrima/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MateriaPrima/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrCodigo,StrNombre,StrDetalles,StrTipo")] MateriaPrima materiaPrima)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materiaPrima);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materiaPrima);
        }

        // GET: MateriaPrima/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.MateriaPrima == null)
            {
                return NotFound();
            }

            var materiaPrima = await _context.MateriaPrima.FindAsync(id);
            if (materiaPrima == null)
            {
                return NotFound();
            }
            return View(materiaPrima);
        }

        // POST: MateriaPrima/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrCodigo,StrNombre,StrDetalles,StrTipo")] MateriaPrima materiaPrima)
        {
            if (id != materiaPrima.StrCodigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materiaPrima);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MateriaPrimaExists(materiaPrima.StrCodigo))
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
            return View(materiaPrima);
        }

        // GET: MateriaPrima/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.MateriaPrima == null)
            {
                return NotFound();
            }

            var materiaPrima = await _context.MateriaPrima
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (materiaPrima == null)
            {
                return NotFound();
            }

            return View(materiaPrima);
        }

        // POST: MateriaPrima/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.MateriaPrima == null)
            {
                return Problem("Entity set 'ViasContext.MateriaPrima'  is null.");
            }
            var materiaPrima = await _context.MateriaPrima.FindAsync(id);
            if (materiaPrima != null)
            {
                _context.MateriaPrima.Remove(materiaPrima);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MateriaPrimaExists(string id)
        {
            return _context.MateriaPrima.Any(e => e.StrCodigo == id);
        }
    }
}
