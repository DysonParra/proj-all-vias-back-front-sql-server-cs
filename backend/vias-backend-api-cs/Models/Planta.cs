/*
 * @fileoverview    {Planta}
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

/**
 * TODO: Description of {@code Planta}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Planta {

        [Key]
        public String? StrCodigo { get; set; }
        public String? StrNombre { get; set; }
        public String? StrDetalles { get; set; }

    }

}