/*
 * @fileoverview    {Producto}
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
using System.ComponentModel.DataAnnotations;

namespace Project.Models {

    /**
     * TODO: Description of {@code Producto}.
     *
     * @author Dyson Parra
     * @since .NET 8 (LTS), C# 12
     */
    public class Producto {

        [Key]
        public String? StrCodigo { get; set; }
        public String? StrNombre { get; set; }
        public String? StrDetalles { get; set; }
        public String? StrTipo { get; set; }

    }

}