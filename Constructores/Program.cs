using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Karen";
            contacto1.Celular = "(622) 123 45 67";
            contacto1.Correo = "Karen@hotmail.com";

            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Celular: " + contacto1.Celular);
            Console.WriteLine("Direccion: " + contacto1.Direccion);

            Contacto contacto2 = new Contacto("Karen", "Karen@hotmail.com");

            Console.WriteLine("*Contacto 2: ");
            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine("Correo: " + contacto2.Correo);
            Console.WriteLine("Direccion: " + contacto2.Direccion);

            Console.Read();
        }
    }
}
