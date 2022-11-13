//ejemplos 3
using System;
namespace Ejercicio3_4
{
    class ejercicio
    {
        static void Main()
        {

            double descuento;
            double precio;
            double total;
            Console.Write("Ingresa el precio del traje: ");
            Console.WriteLine("");
            precio = Convert.ToInt32(Console.ReadLine());
            if (precio > 2500)
            {
                descuento = precio * .15;
            }
            else
            {
                descuento = precio * .08;
            }
            total = precio - descuento;
            Console.Write("El precio final por el traje es: $" + total);
            Console.WriteLine("");
            Console.Write("El descuento aplicado es: $" + descuento);
        }
    }
}
