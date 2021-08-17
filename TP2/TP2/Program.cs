using System;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafetera c = new Cafetera();
            c.InformarCafeDisponible(); //Debe ser 0cc
            c.LlenarCafetera();

            c.ServirTaza(10); //debe servir las 10 tazas
            c.InformarCafeDisponible(); //debe ser 0cc 

            c.ServirTaza(1);//debe arrojar error por falta de cafe
            c.InformarCafeDisponible(); //0cc

            c.LlenarCafetera();

            c.VaciarCafetera();
        }
    }
}
