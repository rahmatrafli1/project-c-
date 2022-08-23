using System;

class LuasLingkaran
{
    static void Main(String[] args)
    {
        const float Phi = 3.14f;

        Console.WriteLine("=== PROGRAM LUAS LINGKARAN ===");
        Console.Write("Input Jari-jari: ");
        float r = float.Parse(Console.ReadLine());

        var luas = Phi * r * r;

        Console.WriteLine($"Luas pada lingkaran adalah {luas} cm2");
    }
}