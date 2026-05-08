using System;
using System.Threading;

class Actividad2_Leccion10_Inciso1_U2
{
    static void Main()
    {
        int num;

        Console.WriteLine("Primeros 20 múltiplos de 4 son...");
        Console.WriteLine("Presiona cualquier tecla para ver el resultado.");

        Console.ReadKey();

        Console.Clear();

        Thread.Sleep(1000);

        for (num = 4; num <= 80; num = num + 4)
        {
            Console.WriteLine(num);
        }

        Console.ReadKey();
    }
}