using System;

/*Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje: 
 * “Te llamas ” <nombre> ” y tienes ” <años> ” años”
 */



namespace _81_IngresarNombreEdad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre y la edad:");

            string n = Convert.ToString(Console.ReadLine());

            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Te llamas " + n + " " + "y tienes " + e + " años");
        }
    }
}
