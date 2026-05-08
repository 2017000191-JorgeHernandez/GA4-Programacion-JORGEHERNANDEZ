intusing System;

class Act2_Lecci10_Inc2
{
    static void Main()
    {
        int num, i;

        Console.WriteLine("Números pares desde 2 hasta x");
        Console.WriteLine("El número tiene que ser mayor a 2");

        Console.Write("Dime un número: ");
        num = int.Parse(Console.ReadLine());

        if (num >= 2)
        {
            for (i = 2; i <= num; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("ERROR");
        }

        Console.ReadKey();
    }
}