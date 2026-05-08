using System;

class Actividad4
{
    static void Main()
    {
        int num = 1;
        int i;

        Console.WriteLine("TABLAS DE MULTIPLICAR");
        Console.WriteLine("No se aceptan números menores que 1");
        Console.WriteLine();

        while (num > 0)
        {
            Console.WriteLine("Dime un número y te diré su tabla");
            Console.Write("Número: ");

            num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("ERROR");
                num = 1;
            }
            else
            {
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine(num + " x " + i + " = " + (num * i));
                }
            }
        }
    }
}