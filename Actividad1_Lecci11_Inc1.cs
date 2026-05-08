using System;

class Act1_Lecci11_Inc1
{
    static void Main()
    {
        int cupos;
        Random aleatorio = new Random();

        Console.WriteLine("PARQUEO GRATIS ZONA 1");
        Console.WriteLine("---------------------");

        cupos = 0;

        do
        {
            Console.WriteLine("Presione cualquier tecla para saber cuántos cupos quedan.");
            Console.WriteLine("--------------------------------------------------------");

            Console.ReadKey();

            cupos = 200 - aleatorio.Next(1, 251);

            if (cupos <= 0)
            {
                Console.WriteLine("Lamentablemente ya no quedan cupos disponibles.");
            }
            else
            {
                Console.WriteLine("Quedan " + cupos + " cupos disponibles todavía.");
            }

            Console.WriteLine("Presione cualquier tecla para actualizar la información.");

            Console.ReadKey();

            Console.Clear();

        } while (cupos > 0);
    }
}