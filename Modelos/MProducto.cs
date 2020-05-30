using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenu6
{
    public class MProducto
    {
        public int Clave { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public double precio { get; set; }
        public int Strock { get; set; }

        public MProducto()
        {
        }

        public MProducto(int clave, string nombre, string descripcion, double precio, int strock)
        {
            Clave = clave;
            Nombre = nombre;
            Descripcion = descripcion;
            this.precio = precio;
            Strock = strock;
        }
    }
}
