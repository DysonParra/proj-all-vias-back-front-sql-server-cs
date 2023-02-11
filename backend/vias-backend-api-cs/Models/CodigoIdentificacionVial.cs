/*
 * @fileoverview    {CodigoIdentificacionVial} se encarga de realizar tareas específicas.
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