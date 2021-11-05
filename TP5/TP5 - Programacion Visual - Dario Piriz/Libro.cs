using System;


namespace BusinessObjects
{
    class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int ISBN { get; set; }
        public int Paginas { get; set; }
        public int Edicion { get; set; }
        public string Editorial { get; set; }
        public string Lugar { get; set; }
        public DateTime FechaDeEdicion { get; set; }

        public Libro(string titulo, string autor, int isbn, int paginas, int edicion, string editorial, string lugar, DateTime fechaDeEdicion, int id = -1)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Paginas = paginas;
            Edicion = edicion;
            Editorial = editorial;
            Lugar = lugar;
            FechaDeEdicion = fechaDeEdicion;
        }

        public Libro()
        {
            // Titulo = "Test Title";
            // Autor = "Test Author";
            // ISBN = 123154845;
            // Paginas = 4;
            // Edicion = 1;
            // Editorial = "Test Editorial";
            // Lugar = "Test Place";
            // FechaDeEdicion = DateTime.Now;
        }

    }
}
