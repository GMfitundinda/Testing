// Code written by Gilbert Mfitundinda
//February/26/2021
//Primenumbercheck
using System;

public class PrimeNumberCheck
{
    public static void Main(string[] args)
    {
        int o, p, q = 0, flag = 0;
        Console.Write("Enter positive integer to check if it is a prime number ");
        o = int.Parse(Console.ReadLine());
        q = o / 2;
        for (p = 2; p <= q; p++)
        {
            if (o % p == 0)
            {
                Console.Write("Positive integer entered is not a prime Number.");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("Positive integer entered is a prime Number.");
    }
}// Gilbert Mfitundinda
//February/25/2021
//Primenumbercheck
using System;
namespace Demo
{
    class MyApplication
    {
        public static void Main()
        {
            int n = 5, a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
            Console.ReadLine();
        }
    }
}