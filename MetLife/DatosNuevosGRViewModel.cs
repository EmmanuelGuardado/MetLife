using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetLife
{
    class DatosNuevosGRViewModel: PolizaViewModel
    {
        public string Estatus { get; set; }
        public string NombreCompleto { get; set; }
        public string RFC { get; set; }
        public string FechaNacimiento { get; set; }
        public string Edad { get; set; }   
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Calle { get; set; }
        public string NoExt { get; set; }
        public string NoInt { get; set; }
        public string CP { get; set; }
        public string Poblacion { get; set; }
        public string Colonia { get; set; }
        public string NombreEmpresa { get; set; }
        public string Ocupacion { get; set; }
        public string SubZona { get; set; }
        public string TelLab { get; set; }
        public string Zona { get; set; }
    }
}
