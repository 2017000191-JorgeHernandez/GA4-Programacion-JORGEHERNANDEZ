using System;

class Program
{
    static void Main()
    {
        int tipo;
        int boletos_ninos = 0, boletos_adultos = 0;
        double total = 0;
        int continuar = 1;

        while (continuar == 1)
        {
            Console.WriteLine("Ingrese el tipo de persona:");
            Console.WriteLine("1 = Niño");
            Console.WriteLine("2 = Adulto");
            tipo = int.Parse(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    boletos_ninos++;
                    total += 10;
                    break;

                case 2:
                    boletos_adultos++;
                    total += 15;
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.WriteLine("¿Desea ingresar otra persona? (1 = Sí, 0 = No)");
            continuar = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("---------------------------");
        Console.WriteLine("Boletos vendidos:");
        Console.WriteLine("Niños: " + boletos_ninos);
        Console.WriteLine("Adultos: " + boletos_adultos);
        Console.WriteLine("Total recaudado: $" + total);
        Console.WriteLine("---------------------------");

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}