using System;

class KelilingLingkaran
{
    static void Main(String[] args)
    {
        const float Phi = 3.14f;

        Console.WriteLine("=== PROGRAM KELILING LINGKARAN ===");
        Console.Write("Input Jari-jari: ");
        float r = float.Parse(Console.ReadLine());

        var kel = 2 * Phi * r;

        Console.WriteLine($"Keliling dari lingkaran adalah {kel} cm");
    }
}