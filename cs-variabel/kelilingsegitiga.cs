using System;

class KelilingSegitiga
{
    static void Main(String[] args)
    {
        Console.WriteLine("=== PROGRAM KELILING SEGITIGA ===");
        Console.Write("a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("c: ");
        float c = float.Parse(Console.ReadLine());

        float kel = a + b + c;

        Console.WriteLine($"Keliling dari segitiga {kel} cm");
    }
}