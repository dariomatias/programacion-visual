using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("ingrese un numero:");
                string input = Console.ReadLine();
                int numero;
                try
                {
                    numero = Int32.Parse(input);
                    string mensaje = numero < 0 ? "negativo" : "positivo";
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
