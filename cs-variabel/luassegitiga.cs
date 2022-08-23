using System;

class LuasSegitiga
{
    static void Main(String[] args)
    {
        Console.WriteLine("=== PROGRAM LUAS SEGITIGA ===");
        Console.Write("Alas: ");
        float alas = float.Parse(Console.ReadLine());

        Console.Write("Tinggi: ");
        float tinggi = float.Parse(Console.ReadLine());

        float luas = alas * tinggi;

        Console.WriteLine($"Luas dari Segitiga adalah {luas} cm2");
    }
}