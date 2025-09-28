using System;
using System.Collections.Generic;

namespace Biblioteca
{
    internal class Lector
    {
        public string Nombre { get; set; }
        public string Dni
        {
            get; set;
        }
        public List<Libro> librosPrestados { get; set; }

        public Lector(string dni, string nombre)
        {
            Dni = dni;
            Nombre = nombre;            
            librosPrestados = new List<Libro>();
        }
    }
}
