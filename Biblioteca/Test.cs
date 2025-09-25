﻿using System;

namespace Biblioteca
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            cargarLibros(biblioteca, 10);
            cargarLibros(biblioteca, 2);
            biblioteca.listarLibros();
            biblioteca.eliminarLibro("Libro5");
            biblioteca.listarLibros();
            void cargarLibros(Biblioteca biblioteca, int cantidad)
            {
                bool pude;
                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (pude)
                        Console.WriteLine("Libro" + i + " agregado correctamente.");
                    else
                        Console.WriteLine("Libro" + i + " Ya existe en la biblioteca.");
                }
            }
        }
    }
}
