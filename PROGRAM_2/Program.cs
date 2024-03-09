using System;


namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido inge wapo");
            Console.WriteLine("Por favor ingresa tu nombre y apellido:");


            string nombre = Console.ReadLine();
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el dominio de correo electrónico (gmail.com, hotmail.com):");
            string dominio = Console.ReadLine();

            string correo = GenerarCorreoElectronico(nombre, apellido, dominio);
            Console.WriteLine("El correo electrónico generado es: " + correo);

            Console.ReadLine();
        }

        static string GenerarCorreoElectronico(string nombre, string apellido, string dominio)
        {
            string primeras3LetrasNombre = nombre.Substring(0, 3).ToLower();
            string primeras3LetrasApellido = apellido.Substring(0, 3).ToLower();

            return primeras3LetrasNombre + primeras3LetrasApellido + "@" + dominio;
        }
    }

}