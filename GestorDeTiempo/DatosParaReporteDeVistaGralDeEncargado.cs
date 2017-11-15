using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeTiempo
{
   public  class DatosParaReporteDeVistaGralDeEncargado
    {
        public int ID {get; set;}
        public string NombrePro { get; set; }
        public string NombreDep { get; set; }
        public string NombreProd { get; set; }
        public string Estado { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string NombreDeUsuario { get; set; }
    }
}
