using System;
using System.Collections.Generic;
using System.Linq;

namespace TP1
{
    class Program
    {
        private static int[] array;
        private const int ELEMENTOS = 20;
        private static int mayor = -1;
        private static int posicion;
        private static Boolean unico = false;

        static void Main(string[] args)
        {
            inicializarArray(elementos: ELEMENTOS);
            cargarArray(elementos: ELEMENTOS);
            analizarArray();

        }

        private static void inicializarArray(int elementos)
        {
            array = new int[elementos];
        }
        private static void cargarArray(int elementos)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(0,100);
        }

        private static void analizarArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mayor)
                {
                    mayor = array[i];
                    posicion = i;
                }
            }
            
            imprimirResultados();
        }

        private static void imprimirResultados()
        {
            Console.WriteLine("El mayor numero dentro del array es " + mayor);
            Console.WriteLine("Dicho numero se encuentra en la posicion " + posicion);
            Console.WriteLine("El array contiene los siguientes valores");
            foreach (int i in array)
                Console.Write(i + ",");
        }
    }
}
