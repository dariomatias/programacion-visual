using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAccess
{
    class DbContext
    {
        SqlConnection cn = new SqlConnection("Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Pruebas; Data Source = KARI\\SQLEXPRESS");
        public void InsertContact(Contacto contacto)
        {
            try
            {
                //abro la coneccion
                cn.Open();

                //creo el sql para insertar
                string query = @"
                                 INSERT INTO Contactos (Apellido, Nombre, Direccion, Telefono) VALUES (@Apellido, @Nombre, @Direccion, @Telefono)";
                //creo los parametrs
                SqlParameter apellido = new SqlParameter();
                apellido.ParameterName = "@apellido";
                apellido.Value = contacto.Apellido;
                apellido.DbType = System.Data.DbType.String;
                SqlParameter nombre = new SqlParameter("@nombre", contacto.Nombre);
                SqlParameter direccion = new SqlParameter("@direccion", contacto.Direccion);
                SqlParameter telefono = new SqlParameter("@telefono", contacto.Telefono);
                //creo el comando mandando os parametro
                SqlCommand comando = new SqlCommand(query, cn);
                comando.Parameters.Add(apellido);
                comando.Parameters.Add(nombre);
                comando.Parameters.Add(direccion);
                comando.Parameters.Add(telefono);
                //Este comando devuelve cantidad de filas afectadas y cero si no
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            //cierra la coneccion
            finally
            {
                cn.Close();
            }
        }
    }
}
