using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el número inicial (i):");
        int i = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de números primos a calcular (n):");
        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        int number = i;

        Console.WriteLine($"Los {n} números primos a partir de {i} son:");

        while (counter < n)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                counter++;
            }

            number++;
        }
    }
}
