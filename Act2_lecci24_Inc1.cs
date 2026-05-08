using System;

class MultiplosDeUnNumero
{
    static void Main()
    {
        int num, contador, multiplo;

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());

        contador = 1;

        do
        {
            multiplo = num * contador;

            Console.WriteLine(multiplo);

            contador++;

        }
        while (contador <= 20);

        Console.ReadKey();
    }
}