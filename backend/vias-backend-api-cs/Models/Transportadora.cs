/*
 * @fileoverview    {Transportadora} se encarga de realizar tareas específicas.
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
 * TODO: Definición de {@code Transportadora}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Transportadora {

        [Key]
        public String? StrNombre { get; set; }
        public String? StrNit { get; set; }
        public String? StrDireccion { get; set; }
        public String? StrTelefono { get; set; }
        public String? StrFax { get; set; }
        public String? StrObservaciones { get; set; }

    }

}