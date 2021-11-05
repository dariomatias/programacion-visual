using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BusinessObjects;

namespace DataAccess
{
    class LibroDbContext
    {
        readonly SqlConnection cn = new SqlConnection("Integrated Security = SSPI; Persist Security Info=False;Initial Catalog = Libreria; Data Source = CORE-NODE\\SQLEXPRESS");

        private static SqlParameter id = new SqlParameter("@id", System.Data.SqlDbType.Int); 
        private static SqlParameter titulo = new SqlParameter("@titulo", System.Data.SqlDbType.VarChar); 
        private static SqlParameter autor = new SqlParameter("@autor", System.Data.SqlDbType.VarChar);
        private static SqlParameter isbn = new SqlParameter("@isbn", System.Data.SqlDbType.Int);
        private static SqlParameter paginas = new SqlParameter("@paginas", System.Data.SqlDbType.Int);
        private static SqlParameter edicion = new SqlParameter("@edicion", System.Data.SqlDbType.Int);
        private static SqlParameter editorial = new SqlParameter("@editorial", System.Data.SqlDbType.VarChar);
        private static SqlParameter lugar = new SqlParameter("@lugar", System.Data.SqlDbType.VarChar);
        private static SqlParameter fechaDeEdicion = new SqlParameter("@fechaDeEdicion", System.Data.SqlDbType.DateTime);
        private static SqlCommand comando;
        public LibroDbContext()
        {
            comando = new SqlCommand();
            comando.Connection = cn;
        }

        private void AddAllParameters()
        {
            comando.Parameters.Clear();
            comando.Parameters.Add(id);
            comando.Parameters.Add(titulo);
            comando.Parameters.Add(autor);
            comando.Parameters.Add(isbn);
            comando.Parameters.Add(paginas);
            comando.Parameters.Add(edicion);
            comando.Parameters.Add(editorial);
            comando.Parameters.Add(lugar);
            comando.Parameters.Add(fechaDeEdicion);
        }

        private void AddIdParameter()
        {
            comando.Parameters.Clear();
            comando.Parameters.Add(id);
        }

        public void InsertarLibro(Libro libro)
        {
            AddAllParameters();
            PopulateParameters(libro);
            try
            {  
                cn.Open(); 
                string query = @"
                                INSERT INTO Libros 
                                (Titulo, Autor, Isbn, Paginas, Edicion, Editorial, Lugar, FechaEdicion) 
                                VALUES 
                                (   @titulo, 
                                    @autor, 
                                    @isbn, 
                                    @paginas, 
                                    @edicion, 
                                    @editorial, 
                                    @lugar, 
                                    @fechaDeEdicion)";

                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                cn.Close();
            }
        }
        
        public void ActualizarLibro(Libro libro)
        {
            AddAllParameters();
            PopulateParameters(libro);
            
            try
            {
                cn.Open();

                string query = @"
                                UPDATE Libros 
                                SET
                                Titulo = @titulo, 
                                Autor = @autor, 
                                Isbn = @isbn, 
                                Paginas = @paginas, 
                                Edicion = @edicion, 
                                Editorial = @editorial, 
                                Lugar = @lugar, 
                                FechaEdicion = @fechaDeEdicion
                                WHERE id = @id";

                comando.CommandText = query;
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                cn.Close();
            }
        }
        
        public void EliminarLibro(int Id)
        {
            comando.Parameters.Clear();

            try
            {
                cn.Open();

                string query = "DELETE from Libros WHERE id = " + Id;

                comando.CommandText = query;
                comando.ExecuteNonQuery();
                
                Console.WriteLine("");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                foreach (SqlParameter parameter in comando.Parameters)
                {
                    parameter.Value = "";
                }
                cn.Close();
            }
        }

        public List<Libro> GetAllRecords()
        {
            List<Libro> libros = new List<Libro>();
            try
            {
                cn.Open();

                string query = @"
                                Select
                                Id, Titulo, Autor, Isbn, Paginas, Edicion, Editorial, Lugar, FechaEdicion 
                                from Libros";

                SqlCommand comando = new SqlCommand(query, cn);

                SqlDataReader reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                    DateTime _FechaDeEdicion = Convert.ToDateTime(reader["FechaEdicion"]);
                    libros.Add(new Libro
                    {
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        ISBN = int.Parse(reader["Isbn"].ToString()),
                        Paginas= int.Parse(reader["Paginas"].ToString()),
                        Edicion= int.Parse(reader["Edicion"].ToString()),
                        Editorial = reader["Editorial"].ToString(),
                        Lugar = reader["Lugar"].ToString(),
                        FechaDeEdicion = _FechaDeEdicion
                    });
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                cn.Close();
            }
            return libros;
        }
        
        public Libro GetLibro(int id)
        {
            Libro libro = new Libro();
            try
            {
                cn.Open();

                string query = @"
                                Select
                                Id, Titulo, Autor, Isbn, Paginas, Edicion, Editorial, Lugar, FechaEdicion 
                                from Libros
                                where id = " + id;

                SqlCommand comando = new SqlCommand(query, cn);

                SqlDataReader reader = comando.ExecuteReader();
                
                while (reader.Read())
                {
                    DateTime _FechaDeEdicion = Convert.ToDateTime(reader["FechaEdicion"]);
                    libro = new Libro
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        ISBN = int.Parse(reader["Isbn"].ToString()),
                        Paginas = int.Parse(reader["Paginas"].ToString()),
                        Edicion = int.Parse(reader["Edicion"].ToString()),
                        Editorial = reader["Editorial"].ToString(),
                        Lugar = reader["Lugar"].ToString(),
                        FechaDeEdicion = _FechaDeEdicion
                    };
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                cn.Close();
            }
            return libro;
        }

        private void PopulateParameters(Libro libro)
        {
            AddAllParameters();
            id.Value = libro.Id;
            titulo.Value = libro.Titulo;
            autor.Value = libro.Autor;
            isbn.Value = libro.ISBN;
            paginas.Value = libro.Paginas;
            edicion.Value = libro.Edicion;
            editorial.Value = libro.Editorial;
            lugar.Value = libro.Lugar;
            fechaDeEdicion.Value = libro.FechaDeEdicion;
        }

        public DataTable GetLibrosActualizados()
        {
            DataTable libros = new DataTable();
            SqlDataAdapter LibrosAdapter;


            LibrosAdapter = new SqlDataAdapter("select * from libros", cn);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(LibrosAdapter);

            libros.Clear();
            LibrosAdapter.Fill(libros);

            return libros;
        }

    }
}
