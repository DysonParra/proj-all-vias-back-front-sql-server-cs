/*
 * @fileoverview    {Configuracion}
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
 * TODO: Definición de {@code Configuracion}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Configuracion {

        [Key]
        public String? StrCodigo { get; set; }
        public String? StrParametro { get; set; }
        public String? StrValor { get; set; }

    }

}