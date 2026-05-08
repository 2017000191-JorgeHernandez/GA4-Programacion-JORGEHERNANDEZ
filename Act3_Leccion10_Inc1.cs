using System;
using System.Threading;

class Actividad3_Leccion10_Inciso1_U2
{
    static void Main()
    {
        int num, suma = 0;

        Console.WriteLine("Suma de números primos");
        Console.WriteLine("Presiona cualquier tecla para continuar");

        Console.ReadKey();

        Console.Clear();

        Thread.Sleep(1000);

        for (num = 2; num <= 100; num++)
        {
            if (num == 2 || num == 3 || num == 5 || num == 7)
            {
                suma = suma + num;
            }
        }

        Console.WriteLine("La suma de los números primos es: " + suma);

        Console.ReadKey();
    }
}