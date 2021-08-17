using System;
namespace TP2
{
    class Cafetera
    {
        private const int taza = 100;
        public int CapacidadMaxima { get; set; }
        private static int CantidadActual { get; set; }

        public Cafetera()
        {
            CapacidadMaxima = 1000;
            CantidadActual = 0;
        }

        public void LlenarCafetera()
        {
            CantidadActual = CapacidadMaxima;
            InformarCafeDisponible();
        }

        public void ServirTaza(int tazas)
        {
            if (CantidadActual < taza * tazas)
                Console.WriteLine("No hay suficiente cafe.");
            else
            {
                CantidadActual -= taza * tazas;
                Console.WriteLine("Cafe(s) servido(s).");
                InformarCafeDisponible();
            }
        }

        public void InformarCafeDisponible()
        {
            Console.WriteLine("Hay " + CantidadActual + "cc de Cafe disponible para su consumo.");
        }

        public void VaciarCafetera()
        {
            CantidadActual = 0;
            Console.WriteLine("Sin cafe. Por favor rellenar.");
        }

    }
}
