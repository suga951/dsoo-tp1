using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca
{
    internal class Biblioteca
    {
        private const int TOPE_PRESTAMOS = 3;
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

            return libros.FirstOrDefault(l => l.titulo == titulo);
        }

        public bool altaLector(string dni, string nombre)
        {

            if (lectores.Any(l => l.Dni == dni))
            {
                return Ya existe un lector con este DNI.;
            }

            Lector nuevoLector = new Lector(dni, nombre);
            lectores.Add(nuevoLector);
            return $"Lector {nombre} agregado exitosamente.;
        }
        
        public string prestarLibro(string titulo, string dni)
        {
            
            Lector lectorSolicitante = lectores.FirstOrDefault(l => l.Dni == dni);
            
            if (lectorSolicitante == null)
            {
                return "LECTOR INEXISTENTE";
            }
            
            Libro libroSolicitado = libros.FirstOrDefault(l => l.titulo == titulo);
            
            if (libroSolicitado == null)
            {
                return "LIBRO INEXISTENTE";
            }

            if (lectorSolicitante.librosPrestados.Count == TOPE_PRESTAMOS)
            {
                return "TOPE DE PRESTAMO ALCANZADO";
            }

            lectorSolicitante.librosPrestados.Add(libroSolicitado);
            libros.Remove(libroSolicitado);
            return "PRESTAMO EXITOSO";
        }
    }
}


