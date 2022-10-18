﻿using System;
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
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;

                int contador = 0;

                string path = "D:\tirar.txt";

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
                
            }

            finally 
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("Archivo cerrado");
            }
            
        }

       
    }
}