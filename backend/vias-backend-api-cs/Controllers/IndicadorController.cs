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
    public class IndicadorController : Controller
    {
        private readonly ViasContext _context;

        public IndicadorController(ViasContext context)
        {
            _context = context;
        }

        // GET: Indicador
        public async Task<IActionResult> Index()
        {
            return View(await _context.Indicador.ToListAsync());
        }

        // GET: Indicador/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Indicador == null)
            {
                return NotFound();
            }

            var indicador = await _context.Indicador
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (indicador == null)
            {
                return NotFound();
            }

            return View(indicador);
        }

        // GET: Indicador/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Indicador/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrCodigo,StrNombre,StrTamanoTrama,StrPosicionInicialPeso,StrTotalDatosPeso,StrCaracterFinTrama,StrCaracterInicioTrama")] Indicador indicador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indicador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indicador);
        }

        // GET: Indicador/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Indicador == null)
            {
                return NotFound();
            }

            var indicador = await _context.Indicador.FindAsync(id);
            if (indicador == null)
            {
                return NotFound();
            }
            return View(indicador);
        }

        // POST: Indicador/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrCodigo,StrNombre,StrTamanoTrama,StrPosicionInicialPeso,StrTotalDatosPeso,StrCaracterFinTrama,StrCaracterInicioTrama")] Indicador indicador)
        {
            if (id != indicador.StrCodigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indicador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndicadorExists(indicador.StrCodigo))
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
            return View(indicador);
        }

        // GET: Indicador/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Indicador == null)
            {
                return NotFound();
            }

            var indicador = await _context.Indicador
                .FirstOrDefaultAsync(m => m.StrCodigo == id);
            if (indicador == null)
            {
                return NotFound();
            }

            return View(indicador);
        }

        // POST: Indicador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Indicador == null)
            {
                return Problem("Entity set 'ViasContext.Indicador'  is null.");
            }
            var indicador = await _context.Indicador.FindAsync(id);
            if (indicador != null)
            {
                _context.Indicador.Remove(indicador);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndicadorExists(string id)
        {
            return _context.Indicador.Any(e => e.StrCodigo == id);
        }
    }
}
