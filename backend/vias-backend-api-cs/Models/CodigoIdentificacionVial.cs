/*
 * @fileoverview    {CodigoIdentificacionVial}
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
 * TODO: Definición de {@code CodigoIdentificacionVial}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class CodigoIdentificacionVial {

        [Key]
        public String? StrCiv { get; set; }
        public String? StrNombreEjeVia { get; set; }
        public String? StrNombreExtremoInicial { get; set; }
        public String? StrNombreExtremoFinal { get; set; }
        public String? StrTipoMalla { get; set; }

    }

}