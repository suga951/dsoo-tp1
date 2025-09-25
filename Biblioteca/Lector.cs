using System;
using System.Collections.Generic;

namespace Biblioteca
{
    internal class Lector
    {
        public string Dni
        {
            get; set;
        }
        public List<Libro> librosPrestados { get; set; }

        public Lector(string dni)
        {
            Dni = dni;
            librosPrestados = new List<Libro>();
        }
    }
}
