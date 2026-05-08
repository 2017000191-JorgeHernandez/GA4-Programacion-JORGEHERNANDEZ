using System;

class BilletesDe100
{
    static void Main()
    {
        int billete, cantidad100, total100;

        cantidad100 = 0;
        total100 = 0;

        Console.WriteLine("Ingrese los billetes.");
        Console.WriteLine("Para terminar escriba 0.");

        do
        {
            billete = int.Parse(Console.ReadLine());

            if (billete == 100)
            {
                cantidad100++;
                total100 = total100 + 100;
            }

        }
        while (billete != 0);

        Console.WriteLine("Cantidad de billetes de 100: " + cantidad100);
        Console.WriteLine("Total de dinero en billetes de 100: $" + total100);

        Console.ReadKey();
    }
}