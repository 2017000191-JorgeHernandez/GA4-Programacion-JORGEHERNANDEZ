using System;

class Actividad3_Leccion11_Inciso1_U2
{
    static void Main()
    {
        int num1, num2, min, max, acumulador, contador;

        acumulador = 0;
        contador = 0;

        Console.WriteLine("Dime dos números y te diré la suma entre esos números");

        Console.Write("Número 1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Número 2: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            max = num1;
            min = num2;

            contador = num2;
        }
        else
        {
            max = num2;
            min = num1;

            contador = num1;
        }

        do
        {
            acumulador = acumulador + contador;
            contador++;
        }
        while (contador <= max);

        Console.WriteLine();
        Console.WriteLine("Resultado: " + acumulador);

        Console.ReadKey();
    }
}