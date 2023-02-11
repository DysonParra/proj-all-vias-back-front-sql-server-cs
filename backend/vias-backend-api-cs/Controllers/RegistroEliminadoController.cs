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
    public class RegistroEliminadoController : Controller
    {
        private readonly ViasContext _context;

        public RegistroEliminadoController(ViasContext context)
        {
            _context = context;
        }

        // GET: RegistroEliminado
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegistroEliminado.ToListAsync());
        }

        // GET: RegistroEliminado/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.RegistroEliminado == null)
            {
                return NotFound();
            }

            var registroEliminado = await _context.RegistroEliminado
                .FirstOrDefaultAsync(m => m.StrPlaca == id);
            if (registroEliminado == null)
            {
                return NotFound();
            }

            return View(registroEliminado);
        }

        // GET: RegistroEliminado/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RegistroEliminado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrPlaca,StrCaso,StrConductor,IntCedula,StrMateriaPrimaProducto,StrClienteProveedor,StrOrigenDestino,StrFechaEntrada,StrHoraEntrada,StrFechaPesoVacio,StrHoraPesoVacio,StrFechaDespachoPlanta,StrHoraDespachoPlanta,StrFechaPesoLleno,StrHoraPesoLleno,StrFechaSalida,StrHoraSalida,IntBruto,IntTara,IntNeto,StrNoShipment,StrNoSello,StrNoR,StrNoContenedor,StrOperario,StrNickOperario,StrObservaciones,StrTransportadora,StrPlanta")] RegistroEliminado registroEliminado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registroEliminado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registroEliminado);
        }

        // GET: RegistroEliminado/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.RegistroEliminado == null)
            {
                return NotFound();
            }

            var registroEliminado = await _context.RegistroEliminado.FindAsync(id);
            if (registroEliminado == null)
            {
                return NotFound();
            }
            return View(registroEliminado);
        }

        // POST: RegistroEliminado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrPlaca,StrCaso,StrConductor,IntCedula,StrMateriaPrimaProducto,StrClienteProveedor,StrOrigenDestino,StrFechaEntrada,StrHoraEntrada,StrFechaPesoVacio,StrHoraPesoVacio,StrFechaDespachoPlanta,StrHoraDespachoPlanta,StrFechaPesoLleno,StrHoraPesoLleno,StrFechaSalida,StrHoraSalida,IntBruto,IntTara,IntNeto,StrNoShipment,StrNoSello,StrNoR,StrNoContenedor,StrOperario,StrNickOperario,StrObservaciones,StrTransportadora,StrPlanta")] RegistroEliminado registroEliminado)
        {
            if (id != registroEliminado.StrPlaca)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registroEliminado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegistroEliminadoExists(registroEliminado.StrPlaca))
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
            return View(registroEliminado);
        }

        // GET: RegistroEliminado/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.RegistroEliminado == null)
            {
                return NotFound();
            }

            var registroEliminado = await _context.RegistroEliminado
                .FirstOrDefaultAsync(m => m.StrPlaca == id);
            if (registroEliminado == null)
            {
                return NotFound();
            }

            return View(registroEliminado);
        }

        // POST: RegistroEliminado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.RegistroEliminado == null)
            {
                return Problem("Entity set 'ViasContext.RegistroEliminado'  is null.");
            }
            var registroEliminado = await _context.RegistroEliminado.FindAsync(id);
            if (registroEliminado != null)
            {
                _context.RegistroEliminado.Remove(registroEliminado);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegistroEliminadoExists(string id)
        {
            return _context.RegistroEliminado.Any(e => e.StrPlaca == id);
        }
    }
}
