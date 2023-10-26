/*
 * @fileoverview    {Vehiculo}
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
 * TODO: Definición de {@code Vehiculo}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class Vehiculo {

        [Key]
        public String? StrCodigo { get; set; }
        public String? StrPlacaVehiculo { get; set; }
        public String? StrNumeroInterno { get; set; }
        public String? StrTara { get; set; }
        public String? StrEjes { get; set; }
        public String? StrVolumenVehiculo { get; set; }
        public String? StrInterno { get; set; }
        public String? StrPatronado { get; set; }
        public String? StrObservacion { get; set; }
        public String? StrIdTransportador { get; set; }

    }

}