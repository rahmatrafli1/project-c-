using System;

class training3
{
    public static void Main(String[] args)
    {
        int angka = 25;

        if ((angka % 2) == 0)
        {
            Console.WriteLine("Faktor terkecil dari " + angka + " adalah 2.");
        }
        else if ((angka % 3) == 0)
        {
            Console.WriteLine("Faktor terkecil dari " + angka + " adalah 3.");
        }
        else if ((angka % 5) == 0)
        {
            Console.WriteLine("Faktor terkecil dari " + angka + " adalah 5.");
        }
        else if ((angka % 7) == 0)
        {
            Console.WriteLine("Faktor terkecil dari " + angka + " adalah 7.");
        }
        else
        {
            Console.WriteLine(angka + " tidak bisa dibagi 2, 3, 5, atau 7.");
        }
    }
}