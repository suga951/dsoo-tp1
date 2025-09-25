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

        public Lector(string nombre, string dni)
        {
            Nombre = nombre;
            Dni = dni;
            librosPrestados = new List<Libro>();
        }
    }
}
