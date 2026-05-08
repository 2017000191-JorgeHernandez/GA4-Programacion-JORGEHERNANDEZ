using System;

class ComprarManzanas
{
    static void Main()
    {
        double pesoManzana, pesoTotal;
        int cantidad;

        pesoTotal = 0;
        cantidad = 0;

        Console.WriteLine("Coloque manzanas en la bascula.");
        Console.WriteLine("El programa termina cuando llegue a 1 kilo o mas.");

        do
        {
            Console.WriteLine("Ingrese el peso de la manzana (en kilos):");
            pesoManzana = double.Parse(Console.ReadLine());

            pesoTotal = pesoTotal + pesoManzana;
            cantidad++;

            Console.WriteLine("Peso acumulado: " + pesoTotal + " kg");

        }
        while (pesoTotal < 1);

        Console.WriteLine("Ya tiene 1 kilo o mas de manzanas.");
        Console.WriteLine("Cantidad de manzanas: " + cantidad);
        Console.WriteLine("Peso total: " + pesoTotal + " kg");

        Console.ReadKey();
    }
}