using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenu6
{
    class AuditoriaDAO
    {
        public List<MAuditoria> GetAll()
        {
            List<MAuditoria> lista = new List<MAuditoria>();

            try
            {
                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText = "SELECT * FROM auditoria order by FechayHora desc;";

                DataTable tabla = Conexion.ejecutarConsulta(sentencia);

                MAuditoria aud;

                foreach (DataRow fila in tabla.Rows)
                {
                    aud = new MAuditoria();
                    aud.Clave = int.Parse(fila["Clave"].ToString());
                    aud.Tabla = fila["Tabla"].ToString();
                    aud.Fecha = fila["FechayHora"].ToString();
                    aud.Tipo = fila["Tipo"].ToString();
                    aud.Valorold = fila["ValorAnterior"].ToString();
                    aud.ValorNew = fila["ValorNuevo"].ToString();
                    aud.Usuario = fila["Usuario"].ToString();
                    lista.Add(aud);
                }

                return lista;
            }
            catch (Exception)
            {
                return lista;
            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
