using System;

class Actividad1_Leccion15_Inciso1_U2
{
    static void Main()
    {
        int hora1, voletos1, voletos2;
        int acumulador1, acumulador2;
        int total1, total2;
        int resultado1, resultado2;

        acumulador1 = 0;
        acumulador2 = 0;
        total1 = 0;
        total2 = 0;

        Console.WriteLine("REGISTRO DE BOLETOS VENDIDOS Y DINERO RECAUDADO.");
        Console.WriteLine("Hora de apertura: 8 a.m.");
        Console.WriteLine("Hora de cierre: 5 p.m.");
        Console.WriteLine();

        do
        {
            Console.WriteLine("¿Cuántos boletos de adulto va a comprar?");
            voletos1 = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántos boletos de niño va a comprar?");
            voletos2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Hora:");
            hora1 = int.Parse(Console.ReadLine());

            resultado1 = 0;
            resultado2 = 0;

            if (voletos1 >= 1)
            {
                resultado1 = voletos1 * 15;
            }

            if (voletos2 >= 1)
            {
                resultado2 = voletos2 * 10;
            }

            acumulador1 = acumulador1 + voletos1;
            acumulador2 = acumulador2 + voletos2;

            total1 = acumulador1 + acumulador2;
            total2 = total2 + resultado1 + resultado2;

        }
        while (hora1 < 1700);

        Console.WriteLine("Total de boletos: " + total1);
        Console.WriteLine("Total de dinero: " + total2);

        Console.ReadKey();
    }
}