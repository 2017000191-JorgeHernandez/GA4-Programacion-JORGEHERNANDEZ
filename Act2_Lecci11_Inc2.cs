using System;

class ImparesDel1Al100
{
    static void Main()
    {
        int num;

        num = 1;

        do
        {
            Console.WriteLine(num);
            num = num + 2;
        }
        while (num <= 100);

        Console.ReadKey();
    }
}