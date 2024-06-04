using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestoMedicina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, introduce la categoría del producto:");
            Console.WriteLine("1. Medicina");
            Console.WriteLine("2. Otro");

            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CalcularImpuesto(0);
                    break;
                case 2:
                    CalcularImpuesto(16);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void CalcularImpuesto(double porcentajeImpuesto)
        {
            Console.Write("Introduce el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            double impuesto = (precio * porcentajeImpuesto) / 100;
            double precioTotal = precio + impuesto;

            Console.WriteLine($"Impuesto: {impuesto:C}");
            Console.WriteLine($"Precio Total: {precioTotal:C}");
        }
    }
}
