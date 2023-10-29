/*
 * @fileoverview    {Cliente}
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
 * TODO: Description of {@code Cliente}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Cliente {

        [Key]
        public String? StrNit { get; set; }
        public String? StrNombre { get; set; }
        public String? StrDireccion { get; set; }
        public String? StrTelefono { get; set; }
        public String? StrFax { get; set; }
        public String? StrObservaciones { get; set; }

    }

}