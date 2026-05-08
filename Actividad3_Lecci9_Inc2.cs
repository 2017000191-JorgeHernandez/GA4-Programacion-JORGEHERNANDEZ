using System;

class Actividad3
{
    static void Main()
    {
        int num = 0;
        int i;

        Console.WriteLine("NÚMEROS IMPARES DE X NÚMERO A 20");

        while (num <= 20)
        {
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                for (i = num + 1; i <= 20; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (i = num; i <= 20; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}