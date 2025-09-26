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

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public void listarLibros()
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }

        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }

        public Libro buscarLibro(string titulo) {
            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].titulo == titulo)
                {
                    return libros[i];
                }
            }
            return null;
        }

        public bool altaLector(string dni, string nombre)
        {

            if (lectores.Any(l => l.Dni == dni))
            {
                Console.WriteLine("Ya existe un lector con este DNI.");
                return false;
            }

            Lector nuevoLector = new Lector(dni, nombre);
            lectores.Add(nuevoLector);
            Console.WriteLine($"Lector {nombre} agregado exitosamente.");
            return true;
        }
        public string prestarLibro(string titulo, string dni)
        {
            Lector lectorSolicitante = lectores.FirstOrDefault(l => l.Dni == dni);
            Libro libroSolicitado = libros.FirstOrDefault(l => l.titulo == titulo);

            if (lectorSolicitante == null)
            {
                Console.WriteLine("LECTOR INEXISTENTE");
            }
            if (lectorSolicitante.librosPrestados.Count >= 3)
            {
                Console.WriteLine("TOPE DE PRESTAMO ALCANZADO");
            }


            if (libroSolicitado == null)
            {
                Console.WriteLine("LIBRO INEXISTENTE");
            }

            lectorSolicitante.librosPrestados.Add(libroSolicitado);
            libros.Remove(libroSolicitado);
            return "PRESTAMO EXITOSO";
        }
    }
}
