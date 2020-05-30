using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenu6
{
    class ProductoDAO
    {
        public Boolean Agregar(MProducto obj)
        {

            try
            {
                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText = "INSERT INTO Productos ( Nombre,Descripcion,Precio,Stock) " +
                    "VALUES('" + obj.Nombre + "','" + obj.Descripcion + "'," + obj.precio + "," + obj.Strock + ");";

                

                Conexion.ejecutarSentencia(sentencia, true);

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Conexion.desconectar();
            }

        }


        public List<MProducto> GetAll()
        {
            List<MProducto> lista = new List<MProducto>();

            try
            {
                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText = "SELECT * FROM Productos;";

                DataTable tabla = Conexion.ejecutarConsulta(sentencia);

                MProducto art;

                foreach (DataRow fila in tabla.Rows)
                {
                    art = new MProducto();
                    art.Clave =int.Parse(fila["Clave"].ToString());
                    art.Nombre = fila["Nombre"].ToString();
                    art.Descripcion = fila["Descripcion"].ToString();
                    art.precio = double.Parse(fila["Precio"].ToString());
                    art.Strock = int.Parse(fila["Stock"].ToString());
                    lista.Add(art);
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

        public MProducto Getbyid(String id)
        {

            MProducto art = new MProducto();
            try
            {
                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText = "SELECT * FROM Productos where clave = " + id + ";";

                DataTable tabla = Conexion.ejecutarConsulta(sentencia);



                foreach (DataRow fila in tabla.Rows)
                {

                    art.Clave = int.Parse(fila["Clave"].ToString());
                    art.Nombre = fila["Nombre"].ToString();
                    art.Descripcion = fila["Descripcion"].ToString();
                    art.precio = double.Parse(fila["Precio"].ToString());
                    art.Strock = int.Parse(fila["Stock"].ToString());

                }

                return art;
            }
            catch (Exception)
            {
                return art;
            }
            finally
            {
                Conexion.desconectar();
            }
        }
        public MProducto GetbyNombre(String Nombre)
        {
            MProducto art = new MProducto();
            try
            {
                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText = "SELECT * FROM Productos where Nombre = '" + Nombre + "';";

                DataTable tabla = Conexion.ejecutarConsulta(sentencia);



                foreach (DataRow fila in tabla.Rows)
                {

                    art.Clave = int.Parse(fila["Clave"].ToString());
                    art.Nombre = fila["Nombre"].ToString();
                    art.Descripcion = fila["Descripcion"].ToString();
                    art.precio = double.Parse(fila["Precio"].ToString());
                    art.Strock = int.Parse(fila["Stock"].ToString());
                    break;

                }

                return art;
            }
            catch (Exception)
            {
                return art;
            }
            finally
            {
                Conexion.desconectar();
            }
        }

        public List<String> GetNombres()
        {
            List<String> lista = new List<String>();

            try
            {
                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText = "SELECT Nombre FROM Productos;";

                DataTable tabla = Conexion.ejecutarConsulta(sentencia);

                MProducto art = new MProducto();

                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(fila["Nombre"].ToString());
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


        public void Eliminar(string id)
        {
            try
            {
                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText = "DELETE FROM Productos WHERE clave = " + id + " ;";
                Conexion.ejecutarSentencia(sentencia, false);

                
            }
            catch (Exception)
            {
                
            }
            finally
            {
                Conexion.desconectar();
            }

        }

        public void Editar(string id, string nombre, string desc, Double precio, int stock) 
        {
            try
            {
                MySqlCommand sentencia = new MySqlCommand();
                sentencia.CommandText = "UPDATE Productos SET Nombre='"+nombre+"',Descripcion='"+desc+"',Precio="+precio+",Stock="+stock+" WHERE clave =" + id + ";";
                Conexion.ejecutarSentencia(sentencia, false);
            }
            catch (Exception)
            {

            }
            finally
            {
                Conexion.desconectar();
            }
        }
    }
}
