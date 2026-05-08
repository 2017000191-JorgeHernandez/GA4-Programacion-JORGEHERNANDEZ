using System;

class SumaPrimos
{
    static void Main()
    {
        int num, i, suma;
        bool esPrimo;

        suma = 0;
        num = 2;

        do
        {
            esPrimo = true;
            i = 2;

            do
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                }

                i++;

            }
            while (i < num && esPrimo == true);

            if (esPrimo == true)
            {
                suma = suma + num;
            }

            num++;

        }
        while (num <= 50);

        Console.WriteLine("La suma de los numeros primos entre 1 y 50 es: " + suma);

        Console.ReadKey();
    }
}