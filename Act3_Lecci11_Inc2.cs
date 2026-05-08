using System;

class Actividad3_Leccion11_Inciso2_U2
{
    static void Main()
    {
        int num, acumulador;

        acumulador = 0;

        Console.WriteLine("Dime números y los iré sumando hasta que presiones 9.");

        do
        {
            Console.Write("Número: ");
            num = int.Parse(Console.ReadLine());

            if (num != 9)
            {
                acumulador = acumulador + num;
            }

        }
        while (num != 9);

        Console.WriteLine();
        Console.WriteLine("El total es: " + acumulador);

        Console.ReadKey();
    }
}