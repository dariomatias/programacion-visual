using BusinessObjects;
using DataAccess;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace TP5___Programacion_Visual___Dario_Piriz
{
    class LibroBusinessLogic
    {
        private static LibroDbContext dbContext;

        public LibroBusinessLogic()
        {
            dbContext = new LibroDbContext();
        }

        public bool GuardarRegistro(Libro libro)
        {
            dbContext.InsertarLibro(libro);
            return true;
        }
        
        public bool ActualizarRegistro(Libro libro)
        {
            dbContext.ActualizarLibro(libro);
            return true;
        }
        
        public bool EliminarRegistro(int id)
        {
            dbContext.EliminarLibro(id);
            return true;
        }

        public List<Libro> GetAllRecords()
        {
            return dbContext.GetAllRecords();
        }
        
        public Libro GetLibro(int id)
        {
            return dbContext.GetLibro(id);
        }

        public DataTable GetLibrosActualizados()
        {
            return dbContext.GetLibrosActualizados();
        }
    }
}
