using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        public bool altaLector(string dni, string nombre)
        {

            if (lectores.Any(l => l.Dni == dni))
            {
                Console.WriteLine("Ya existe un lector con este DNI.")
                return false;
            }

            Lector nuevoLector = new Lector(dni, nombre);
            lectores.Add(nuevoLector);
            Console.WriteLine($"Lector {nombre} agregado exitosamente.");
            return true;
        }
        public string prestarLibro(string titulo, string dni)
        {
            if (dni == null)
            {
                Console.WriteLine("LECTOR INEXISTENTE");
            }
            if (titulo == null)
            {
                Console.WriteLine("LIBRO INEXISTENTE");
            }
        }
    }
}
