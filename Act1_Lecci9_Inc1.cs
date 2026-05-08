using System;

class Program
{
    static void Main()
    {
        double pesoAcumulado = 0;
        double pesoManzana;
        int contador = 0;

        Console.WriteLine("=============================");
        Console.WriteLine("Báscula del mercado");
        Console.WriteLine("=============================");

        while (pesoAcumulado < 1000)
        {
            Console.Write("Ingresa el peso de la manzana (100 - 300 gramos): ");
            pesoManzana = double.Parse(Console.ReadLine());

            if (pesoManzana >= 100 && pesoManzana <= 300)
            {
                pesoAcumulado = pesoAcumulado + pesoManzana;
                contador++;

                Console.WriteLine("Peso acumulado: " + pesoAcumulado + " gramos");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }

        Console.WriteLine("1000 gramos alcanzados.");
        Console.WriteLine("Tiene " + (pesoAcumulado / 1000) + " kilos en manzanas.");
        Console.WriteLine("Total de manzanas: " + contador);

        Console.ReadKey();
    }
}