using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetLife
{
    class DatosNuevosGMViewModel:PolizaViewModel
    {
        public string Promotoria { get; set; }
        public string Cliente { get; set; }
        public string RFC { get; set; }
        public string FechaEmisionPoliza { get; set; }
        public string Estatus { get; set; }
        public string IDNominal { get; set; }
        public string Retenedor { get; set; }
        public string UnidadPago { get; set; }
        public string ConceptoDescuento { get; set; }
        public string Plan { get; set; }
        public string PrimaAlCobro { get; set; }


        public string FechaUltimoDescuento { get; set; }
        public string AQUltimoDescuento { get; set; }
        public string ImporteUltimoDescuento { get; set; }
        public string UltimoIncremento { get; set; }
        public string UltimoRetiroReserva { get; set; }
        public string MontoReserva { get; set; }
        public string MontoFondoInversion { get; set; }
        public string RecibosPendientes { get; set; }

        public double MRP { get; set; }
    }
}
