using System;

namespace Biblioteca
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Console.WriteLine("====== CARGA DE LIBROS ======");
            cargarLibros(biblioteca, 10);
            // Prueba de carga de libros duplicados
            cargarLibros(biblioteca, 2);

            Console.WriteLine("\n====== LISTADO DE LIBROS ======");
            biblioteca.listarLibros();

            Console.WriteLine("\n====== ELIMINAR LIBRO ======");
            // Prueba de elimicacion de libro exitosa
            biblioteca.eliminarLibro("Libro5");
            biblioteca.listarLibros();

            Console.WriteLine("\n====== REGISTRO DE LECTORES ======");
            // Prueba de carga de lectores exitosa
            Console.WriteLine(biblioteca.altaLector("123", "Ana"));
            Console.WriteLine(biblioteca.altaLector("456", "Luis"));
            // Prueba de DNI duplicado
            Console.WriteLine(biblioteca.altaLector("123", "Ana repetida"));

            Console.WriteLine("\n====== Prestamo de libros ======");
            // Prueba de carga de libro exitoso
            Console.WriteLine(biblioteca.prestarLibro("Libro1", "123"));
            Console.WriteLine(biblioteca.prestarLibro("Libro2", "123"));
            Console.WriteLine(biblioteca.prestarLibro("Libro3", "123"));
            // Prueba de tope de prestamo alcanzado
            Console.WriteLine(biblioteca.prestarLibro("Libro4", "123"));
            // Prueba de libro inexistente
            Console.WriteLine(biblioteca.prestarLibro("Libro100", "123"));
            // Prueba de lector inexistente
            Console.WriteLine(biblioteca.prestarLibro("Libro6", "999"));

            Console.WriteLine("\n====== Listado de ultimos libros disponibles ======");
            biblioteca.listarLibros();

            // Metodo auxiliar para cargar libros
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
