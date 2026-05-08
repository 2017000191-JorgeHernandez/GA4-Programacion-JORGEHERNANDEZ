using System;

class MultiplosDe7
{
    static void Main()
    {
        int num, contador, suma, cantidadPares;

        contador = 1;
        suma = 0;
        cantidadPares = 0;

        do
        {
            num = contador * 7;
            suma = suma + num;

            if (num % 2 == 0)
            {
                cantidadPares++;
            }

            contador++;

        }
        while (contador <= 20);

        Console.WriteLine("La suma de los primeros 20 multiplos de 7 es: " + suma);
        Console.WriteLine("Cantidad de numeros pares: " + cantidadPares);

        Console.ReadKey();
    }
}