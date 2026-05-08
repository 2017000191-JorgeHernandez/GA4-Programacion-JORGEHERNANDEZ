using System;

class Act1_Lecci10_Inc1
{
    static void Main()
    {
        int i;

        Console.WriteLine("===========================");
        Console.WriteLine("Cuponera de Presi");

        for (i = 1; i <= 8; i++)
        {
            Console.WriteLine("Presione una tecla para marcar el sello: " + i);

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Sello " + i + " marcado...");
            Console.WriteLine();
        }

        Console.WriteLine("Felicidades haz completado los 8 sellos.");
        Console.WriteLine("Corte gratis!!!!!");

        Console.ReadKey();
    }
}