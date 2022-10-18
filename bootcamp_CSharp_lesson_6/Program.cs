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
            checked{

                int numero = int.MaxValue;

                int resultado = numero + 20;

                Console.WriteLine(resultado);

            }
        }


    }
}