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

            Console.WriteLine("Introduce n° de mes");

            int numeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(NombreDelMes(numeroMes));

            }
            catch (Exception ex)
            {

                Console.WriteLine("Mensaje de la excepción: " + ex.Message);
            }


            Console.WriteLine("Aquí continuaría la ejecución del resto del programa");
            
        }

        public static string NombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "Enero";

                case 2:
                    return "Febrero";

                case 3:
                    return "Marzo";

                case 4:
                    return "Abril";

                case 5:
                    return "Mayo";

                case 6:
                    return "Junio";

                case 7:
                    return "Julio";

                case 8:
                    return "Agosto";

                case 9:
                    return "Septiembre";

                case 10:
                    return "Octubre";

                case 11:
                    return "Noviembre";

                case 12:
                    return "Diciembre";

                default:

                    //.NET framework library
                    //lanzar
                    throw new ArgumentOutOfRangeException();
            }

        }
    }
}