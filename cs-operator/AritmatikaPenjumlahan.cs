using System;

class AritmatikaPenjumlahan
{
    public static void Main(String[] args)
    {
        int mangga, apel, hasil = 0;

        Console.Write("mangga: ");
        mangga = int.Parse(Console.ReadLine());
        Console.Write("apel: ");
        apel = int.Parse(Console.ReadLine());

        // hasil operator penjumlahan
        hasil = mangga + apel;

        Console.WriteLine($"Hasil {mangga} + {apel} = {hasil}");
    }
}