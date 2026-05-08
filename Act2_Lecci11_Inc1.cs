using System;

class FactorialConDoWhile
{
    static void Main()
    {
        int num, factorial, i;

        Console.WriteLine("Ingrese un numero entero:");
        num = int.Parse(Console.ReadLine());

        factorial = 1;
        i = 1;

        do
        {
            factorial = factorial * i;
            i++;
        }
        while (i <= num);

        Console.WriteLine("El factorial de " + num + " es: " + factorial);

        Console.ReadKey();
    }
}