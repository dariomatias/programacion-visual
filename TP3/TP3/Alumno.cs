﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Legajo { get; set; }
        public string Carrera { get; set; }
        public int AnioDeInscripcion { get; set; }

        public Alumno(string nombre, string apellido, int dni, string legajo, string carrera, int anioDeInscripcion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Legajo = legajo;
            Carrera = carrera;
            AnioDeInscripcion = anioDeInscripcion;
        }
    }
}
