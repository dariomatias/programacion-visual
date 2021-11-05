using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BusinessObjects
{
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public int Paginas { get; set; }
        public int Edicion { get; set; }
        public string Editorial { get; set; }
        public string Lugar { get; set; }
        public DateTime FechaDeEdicion { get; set; }

        public Libro(string titulo,
            string autor,
            int isbn,
            int paginas,
            int edicion,
            string editorial,
            string lugar,
            DateTime fechaDeEdicion)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Paginas = paginas;
            Edicion = edicion;
            Editorial = editorial;
            Lugar = lugar;
            FechaDeEdicion = fechaDeEdicion;
        }

    }
}
