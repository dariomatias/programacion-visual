using System;

namespace Ejercicio4
{
    class Program
    {
        private static int impares = 0;
        private static int pares = 0;

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("ingrese un numero:");
                string input = Console.ReadLine();
                int numero;
                try
                {
                    numero = Int32.Parse(input);
                    bool par = (numero % 2) == 0;
                    if (par) pares++;
                    else impares++;

                    string mensaje = par ? "par" : "impar";
                    Console.WriteLine("El numero ingresado es " + mensaje);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: EL VALOR INGRESADO NO ES UN NUMERO.");
                    i--;
                }
            }
        }
    }
}
