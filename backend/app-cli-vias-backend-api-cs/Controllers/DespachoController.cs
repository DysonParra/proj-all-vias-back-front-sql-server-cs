/*
 * @fileoverview    {DespachoController}
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

namespace Vias.Controllers
{
    public class DespachoController : Controller
    {
        private readonly ViasContext _context;

        public DespachoController(ViasContext context)
        {
            _context = context;
        }

        // GET: Despacho
        public async Task<IActionResult> Index()
        {
            return View(await _context.Despacho.ToListAsync());
        }

        // GET: Despacho/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Despacho == null)
            {
                return NotFound();
            }

            var despacho = await _context.Despacho
                .FirstOrDefaultAsync(m => m.IntNoTiquete == id);
            if (despacho == null)
            {
                return NotFound();
            }

            return View(despacho);
        }

        // GET: Despacho/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Despacho/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IntNoTiquete,StrPlaca,StrConductor,IntCedula,StrProducto,StrFechaEntrada,StrHoraEntrada,StrFechaPesoVacio,StrHoraPesoVacio,StrFechaDespachoPlanta,StrHoraDespachoPlanta,StrFechaPesoLleno,StrHoraPesoLleno,StrFechaSalida,StrHoraSalida,IntBruto,IntTara,IntNeto,StrNoShipment,StrNoSello,StrNoR,StrNoContenedor,StrOperario,StrNickOperario,StrObservaciones,StrNoInterno,StrCodigo,StrTipoVehiculo,StrTipoProducto,StrDireccion,StrEntregadoPor,StrRecibidoPor,StrUnidad,StrVolumen,StrCiv,StrIdProducto,StrDestino,StrCliente,StrPlanta,StrTransportadora")] Despacho despacho)
        {
            if (ModelState.IsValid)
            {
                _context.Add(despacho);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(despacho);
        }

        // GET: Despacho/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Despacho == null)
            {
                return NotFound();
            }

            var despacho = await _context.Despacho.FindAsync(id);
            if (despacho == null)
            {
                return NotFound();
            }
            return View(despacho);
        }

        // POST: Despacho/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("IntNoTiquete,StrPlaca,StrConductor,IntCedula,StrProducto,StrFechaEntrada,StrHoraEntrada,StrFechaPesoVacio,StrHoraPesoVacio,StrFechaDespachoPlanta,StrHoraDespachoPlanta,StrFechaPesoLleno,StrHoraPesoLleno,StrFechaSalida,StrHoraSalida,IntBruto,IntTara,IntNeto,StrNoShipment,StrNoSello,StrNoR,StrNoContenedor,StrOperario,StrNickOperario,StrObservaciones,StrNoInterno,StrCodigo,StrTipoVehiculo,StrTipoProducto,StrDireccion,StrEntregadoPor,StrRecibidoPor,StrUnidad,StrVolumen,StrCiv,StrIdProducto,StrDestino,StrCliente,StrPlanta,StrTransportadora")] Despacho despacho)
        {
            if (id != despacho.IntNoTiquete)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(despacho);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DespachoExists(despacho.IntNoTiquete))
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
            return View(despacho);
        }

        // GET: Despacho/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Despacho == null)
            {
                return NotFound();
            }

            var despacho = await _context.Despacho
                .FirstOrDefaultAsync(m => m.IntNoTiquete == id);
            if (despacho == null)
            {
                return NotFound();
            }

            return View(despacho);
        }

        // POST: Despacho/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.Despacho == null)
            {
                return Problem("Entity set 'ViasContext.Despacho'  is null.");
            }
            var despacho = await _context.Despacho.FindAsync(id);
            if (despacho != null)
            {
                _context.Despacho.Remove(despacho);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DespachoExists(int? id)
        {
            return _context.Despacho.Any(e => e.IntNoTiquete == id);
        }
    }
}
