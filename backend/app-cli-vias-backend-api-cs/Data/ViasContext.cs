/*
 * @fileoverview    {ViasContext}
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
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Vias.Data {

    /**
     * TODO: Description of {@code ViasContext}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class ViasContext : DbContext {
        public ViasContext (DbContextOptions<ViasContext> options)
            : base(options) {
        }

        public DbSet<Project.Models.Ayudante> Ayudante { get; set; } = default!;

        public DbSet<Project.Models.Cliente> Cliente { get; set; }

        public DbSet<Project.Models.CodigoIdentificacionVial> CodigoIdentificacionVial { get; set; }

        public DbSet<Project.Models.Conductor> Conductor { get; set; }

        public DbSet<Project.Models.Configuracion> Configuracion { get; set; }

        public DbSet<Project.Models.Despacho> Despacho { get; set; }

        public DbSet<Project.Models.Destino> Destino { get; set; }

        public DbSet<Project.Models.Indicador> Indicador { get; set; }

        public DbSet<Project.Models.Ingreso> Ingreso { get; set; }

        public DbSet<Project.Models.MateriaPrima> MateriaPrima { get; set; }

        public DbSet<Project.Models.Origen> Origen { get; set; }

        public DbSet<Project.Models.Planta> Planta { get; set; }

        public DbSet<Project.Models.Producto> Producto { get; set; }

        public DbSet<Project.Models.Proveedor> Proveedor { get; set; }

        public DbSet<Project.Models.RegistroEliminado> RegistroEliminado { get; set; }

        public DbSet<Project.Models.Transportadora> Transportadora { get; set; }

        public DbSet<Project.Models.Usuario> Usuario { get; set; }

        public DbSet<Project.Models.Vehiculo> Vehiculo { get; set; }

        public DbSet<Project.Models.VehiculoEnTransito> VehiculoEnTransito { get; set; }
    }
}
