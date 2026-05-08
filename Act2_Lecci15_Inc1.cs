using System;

class NumerosPrimos
{
    static void Main()
    {
        int num, i, contador, suma;
        bool esPrimo;

        contador = 0;
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
                contador++;
                suma = suma + num;
            }

            num++;

        }
        while (num <= 100);

        Console.WriteLine("Cantidad de numeros primos entre 1 y 100: " + contador);
        Console.WriteLine("La suma de los numeros primos es: " + suma);

        Console.ReadKey();
    }
}