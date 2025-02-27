/*
 * @fileoverview    {VehiculoEnTransitoController}
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
     * TODO: Description of {@code VehiculoEnTransitoController}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class VehiculoEnTransitoController : Controller {
        private readonly ViasContext _context;

        /**
         * TODO: Description of method {@code VehiculoEnTransitoController}.
         *
         */
        public VehiculoEnTransitoController(ViasContext context) {
            _context = context;
        }

        /**
         * GET: VehiculoEnTransito
         *
         */
        public async Task<IActionResult> Index() {
            return View(await _context.VehiculoEnTransito.ToListAsync());
        }

        /**
         * GET: VehiculoEnTransito/Details/5
         *
         */
        public async Task<IActionResult> Details(string id) {
            if (id == null || _context.VehiculoEnTransito == null) {
                return NotFound();
            }

            var vehiculoEnTransito = await _context.VehiculoEnTransito
                .FirstOrDefaultAsync(m => m.StrPlaca == id);
            if (vehiculoEnTransito == null) {
                return NotFound();
            }

            return View(vehiculoEnTransito);
        }

        /**
         * GET: VehiculoEnTransito/Create
         *
         */
        public IActionResult Create() {
            return View();
        }

        /**
         * POST: VehiculoEnTransito/Create
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StrPlaca,StrCaso,StrConductor,IntCedula,StrMateriaPrimaProducto,StrClienteProveedor,StrOrigenDestino,StrFechaEntrada,StrHoraEntrada,StrFechaPesoVacio,StrHoraPesoVacio,StrFechaDespachoPlanta,StrHoraDespachoPlanta,StrFechaPesoLleno,StrHoraPesoLleno,StrFechaSalida,StrHoraSalida,IntBruto,IntTara,IntNeto,IntNoTiquete,StrNoShipment,StrNoSello,StrNoR,StrNoContenedor,StrOperario,StrNickOperario,StrObservaciones,StrNoInterno,StrTipoVehiculo,StrEntregadoPor,StrRecibidoPor,StrDireccion,StrTipoProducto,StrUnidad,StrVolumen,StrCiv,StrIdProducto,StrIdVehiculo,StrPlanta,StrTransportadora")] VehiculoEnTransito vehiculoEnTransito) {
            if (ModelState.IsValid) {
                _context.Add(vehiculoEnTransito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculoEnTransito);
        }

        /**
         * GET: VehiculoEnTransito/Edit/5
         *
         */
        public async Task<IActionResult> Edit(string id) {
            if (id == null || _context.VehiculoEnTransito == null) {
                return NotFound();
            }

            var vehiculoEnTransito = await _context.VehiculoEnTransito.FindAsync(id);
            if (vehiculoEnTransito == null) {
                return NotFound();
            }
            return View(vehiculoEnTransito);
        }

        /**
         * POST: VehiculoEnTransito/Edit/5
         * To protect from overposting attacks, enable the specific properties you want to bind to.
         * For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
         *
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("StrPlaca,StrCaso,StrConductor,IntCedula,StrMateriaPrimaProducto,StrClienteProveedor,StrOrigenDestino,StrFechaEntrada,StrHoraEntrada,StrFechaPesoVacio,StrHoraPesoVacio,StrFechaDespachoPlanta,StrHoraDespachoPlanta,StrFechaPesoLleno,StrHoraPesoLleno,StrFechaSalida,StrHoraSalida,IntBruto,IntTara,IntNeto,IntNoTiquete,StrNoShipment,StrNoSello,StrNoR,StrNoContenedor,StrOperario,StrNickOperario,StrObservaciones,StrNoInterno,StrTipoVehiculo,StrEntregadoPor,StrRecibidoPor,StrDireccion,StrTipoProducto,StrUnidad,StrVolumen,StrCiv,StrIdProducto,StrIdVehiculo,StrPlanta,StrTransportadora")] VehiculoEnTransito vehiculoEnTransito) {
            if (id != vehiculoEnTransito.StrPlaca) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(vehiculoEnTransito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) {
                    if (!VehiculoEnTransitoExists(vehiculoEnTransito.StrPlaca)) {
                        return NotFound();
                    }
                    else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculoEnTransito);
        }

        /**
         * GET: VehiculoEnTransito/Delete/5
         *
         */
        public async Task<IActionResult> Delete(string id) {
            if (id == null || _context.VehiculoEnTransito == null) {
                return NotFound();
            }

            var vehiculoEnTransito = await _context.VehiculoEnTransito
                .FirstOrDefaultAsync(m => m.StrPlaca == id);
            if (vehiculoEnTransito == null) {
                return NotFound();
            }

            return View(vehiculoEnTransito);
        }

        /**
         * POST: VehiculoEnTransito/Delete/5
         *
         */
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id) {
            if (_context.VehiculoEnTransito == null) {
                return Problem("Entity set 'ViasContext.VehiculoEnTransito'  is null.");
            }
            var vehiculoEnTransito = await _context.VehiculoEnTransito.FindAsync(id);
            if (vehiculoEnTransito != null) {
                _context.VehiculoEnTransito.Remove(vehiculoEnTransito);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        /**
         * TODO: Description of method {@code VehiculoEnTransitoExists}.
         *
         */
        private bool VehiculoEnTransitoExists(string id) {
            return _context.VehiculoEnTransito.Any(e => e.StrPlaca == id);
        }
    }
}
