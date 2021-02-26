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
    }