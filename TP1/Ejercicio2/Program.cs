using System;

namespace Ejercicio2
{
    class Program
    {
        private static int[] A = new int[30];
        private static int[] B = new int[30];
        private static int[] C = new int[30];

        static void Main(string[] args)
        {
            cargarArrays();
            generarNuevoArray();

            imprimirArray(A);
            imprimirArray(B);
            imprimirArray(C);
        }

        private static void cargarArrays()
        {
            Random random = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(1, 999);
                B[i] = random.Next(1, 999);
            }
        }

        private static void generarNuevoArray()
        {
            for (int i = 0; i < C.Length; i++)
                C[i] = A[i] + B[i];
        }
        

        private static void imprimirArray(int[] array, string name = "")
        {
            Console.WriteLine("Array " + name + " :");
            foreach (int i in array)
                Console.Write(i + ",");
        }
    }
}
