/*
 * @fileoverview    {IngresoController}
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
     * TODO: Description of {@code IngresoController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class IngresoController : Controller {
        private readonly ViasContext _context;

        public IngresoController(ViasContext context) {
            _context = context;
        }

        // GET: Ingreso
        public async Task<IActionResult> Index() {
            return View(await _context.Ingreso.ToListAsync());
        }

        // GET: Ingreso/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null || _context.Ingreso == null) {
                return NotFound();
            }

            var ingreso = await _context.Ingreso
                .FirstOrDefaultAsync(m => m.IntNoTiquete == id);
            if (ingreso == null) {
                return NotFound();
            }

            return View(ingreso);
        }

        // GET: Ingreso/Create
        public IActionResult Create() {
            return View();
        }

        // POST: Ingreso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IntNoTiquete,StrPlaca,StrConductor,IntCedula,StrProveedor,StrFechaEntrada,StrHoraEntrada,StrFechaPesoVacio,StrHoraPesoVacio,StrFechaDespachoPlanta,StrHoraDespachoPlanta,StrFechaPesoLleno,StrHoraPesoLleno,StrFechaSalida,StrHoraSalida,IntBruto,IntTara,IntNeto,StrNoShipment,StrNoSello,StrNoR,StrNoContenedor,StrOperario,StrNickOperario,StrObservaciones,StrNoInterno,StrCodigo,StrTipoVehiculo,StrTipoProducto,StrDireccion,StrEntregadoPor,StrRecibidoPor,StrUnidad,StrVolumen,StrMateriaPrima,StrPlanta,StrTransportadora,StrOrigen")] Ingreso ingreso) {
            if (ModelState.IsValid) {
                _context.Add(ingreso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ingreso);
        }

        // GET: Ingreso/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null || _context.Ingreso == null) {
                return NotFound();
            }

            var ingreso = await _context.Ingreso.FindAsync(id);
            if (ingreso == null) {
                return NotFound();
            }
            return View(ingreso);
        }

        // POST: Ingreso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("IntNoTiquete,StrPlaca,StrConductor,IntCedula,StrProveedor,StrFechaEntrada,StrHoraEntrada,StrFechaPesoVacio,StrHoraPesoVacio,StrFechaDespachoPlanta,StrHoraDespachoPlanta,StrFechaPesoLleno,StrHoraPesoLleno,StrFechaSalida,StrHoraSalida,IntBruto,IntTara,IntNeto,StrNoShipment,StrNoSello,StrNoR,StrNoContenedor,StrOperario,StrNickOperario,StrObservaciones,StrNoInterno,StrCodigo,StrTipoVehiculo,StrTipoProducto,StrDireccion,StrEntregadoPor,StrRecibidoPor,StrUnidad,StrVolumen,StrMateriaPrima,StrPlanta,StrTransportadora,StrOrigen")] Ingreso ingreso) {
            if (id != ingreso.IntNoTiquete) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(ingreso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!IngresoExists(ingreso.IntNoTiquete)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ingreso);
        }

        // GET: Ingreso/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null || _context.Ingreso == null) {
                return NotFound();
            }

            var ingreso = await _context.Ingreso
                .FirstOrDefaultAsync(m => m.IntNoTiquete == id);
            if (ingreso == null) {
                return NotFound();
            }

            return View(ingreso);
        }

        // POST: Ingreso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id) {
            if (_context.Ingreso == null) {
                return Problem("Entity set 'ViasContext.Ingreso'  is null.");
            }
            var ingreso = await _context.Ingreso.FindAsync(id);
            if (ingreso != null) {
                _context.Ingreso.Remove(ingreso);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IngresoExists(int? id) {
            return _context.Ingreso.Any(e => e.IntNoTiquete == id);
        }
    }
}
