using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenu6
{
    class MAuditoria
    {
        public int Clave { get; set; }
        public String Tabla { get; set; }
        public String Fecha { get; set; }
        public String Tipo { get; set; }
        public String Valorold { get; set; }
        public String ValorNew { get; set; }
        public String Usuario { get; set; }

        public MAuditoria()
        {
        }

        public MAuditoria(int clave, string tabla, string fecha, string tipo, string valorold, string valorNew, string usuario)
        {
            Clave = clave;
            Tabla = tabla;
            Fecha = fecha;
            Tipo = tipo;
            Valorold = valorold;
            ValorNew = valorNew;
            Usuario = usuario;
        }
    }
}
