/*
 * @fileoverview    {RegistroEliminado}
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
 * TODO: Description of {@code RegistroEliminado}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class RegistroEliminado {

        [Key]
        public String? StrPlaca { get; set; }
        public String? StrCaso { get; set; }
        public String? StrConductor { get; set; }
        public Int32? IntCedula { get; set; }
        public String? StrMateriaPrimaProducto { get; set; }
        public String? StrClienteProveedor { get; set; }
        public String? StrOrigenDestino { get; set; }
        public String? StrFechaEntrada { get; set; }
        public String? StrHoraEntrada { get; set; }
        public String? StrFechaPesoVacio { get; set; }
        public String? StrHoraPesoVacio { get; set; }
        public String? StrFechaDespachoPlanta { get; set; }
        public String? StrHoraDespachoPlanta { get; set; }
        public String? StrFechaPesoLleno { get; set; }
        public String? StrHoraPesoLleno { get; set; }
        public String? StrFechaSalida { get; set; }
        public String? StrHoraSalida { get; set; }
        public Int32? IntBruto { get; set; }
        public Int32? IntTara { get; set; }
        public Int32? IntNeto { get; set; }
        public String? StrNoShipment { get; set; }
        public String? StrNoSello { get; set; }
        public String? StrNoR { get; set; }
        public String? StrNoContenedor { get; set; }
        public String? StrOperario { get; set; }
        public String? StrNickOperario { get; set; }
        public String? StrObservaciones { get; set; }
        public String? StrTransportadora { get; set; }
        public String? StrPlanta { get; set; }

    }

}