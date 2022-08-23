using System;

class training2
{
    public static void Main(String[] args)
    {
        int level = 29;
        string jenisSerangan = "Serangan Berat";

        if (jenisSerangan == "Serangan Jarak Jauh")
        {
            if (level >= 50)
            {
                Console.WriteLine("Menghindar dan Melompat");
            }
            else
            {
                Console.WriteLine("Menahan Serangan");
            }
        }
        else if (jenisSerangan == "Serangan Berat")
        {
            if (level >= 30)
            {
                Console.WriteLine("Menyerang dengan Serangan Cepat");
            }
            else
            {
                Console.WriteLine("Menghindar dan Mundur");
            }
        }
        else
        {
            if (level >= 70)
            {
                Console.WriteLine("Menghindar dan Mundur");
            }
            else
            {
                Console.WriteLine("Menahan Serangan");
            }
        }
    }
}