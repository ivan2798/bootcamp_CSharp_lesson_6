using System;
using System.Collections.Concurrent;
using System.Security.Cryptography;

// Hello World! program
namespace bootcamp_CSharp_lesson_6
{
    class Program
    {
        // intellisense

        static void Main(string[] args)
        {
            Random numero = new Random();  
            
            int aleatorio = numero.Next(0,100);

            int miNumero;

            int intentos = 0;

            Console.WriteLine("Introduce un n° entre 0 y 100");


            do {
                intentos++;

                try
                {

                    miNumero = int.Parse(Console.ReadLine());

                }
                catch(FormatException ex)
                {
                    Console.WriteLine("No has introducido un valor numérico válido. Se toma como n° introducido el 0");  
                    miNumero = 0;
                }

                if (miNumero > aleatorio) Console.WriteLine("El n° es más bajo");

                if (miNumero < aleatorio) Console.WriteLine("El n° es más alto");

            } while (aleatorio != miNumero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            Console.WriteLine("A partir de esta línea de código el programa continuaría");

        }


    }
}