using System;

class CuentaRegresivaYSuma
{
    static void Main()
    {
        int num, suma;

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());

        suma = 0;

        do
        {
            Console.WriteLine(num);
            suma = suma + num;

            num = num - 1;

        }
        while (num >= 1);

        Console.WriteLine("La suma total es: " + suma);

        Console.ReadKey();
    }
}