using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    internal class Libro
    {
        public string titulo { get; }
        public string autor { get; }
        public string editorial { get; }

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        public override string ToString()
        {
            return "Titulo: " + titulo + " Autor: " + autor + " Editorial: " + editorial;
        }
    }
}
