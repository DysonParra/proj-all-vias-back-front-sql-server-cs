/*
 * @fileoverview    {Conductor}
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
 * TODO: Definición de {@code Conductor}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Conductor {

        [Key]
        public Int32? IntCedula { get; set; }
        public String? StrNombre { get; set; }
        public String? StrEstado { get; set; }

    }

}