using System;

class AritmatikaSisaBagi
{
    public static void Main(String[] args)
    {
        int mangga, apel, hasil = 0;

        Console.Write("mangga: ");
        mangga = int.Parse(Console.ReadLine());
        Console.Write("apel: ");
        apel = int.Parse(Console.ReadLine());

        // hasil operator sisa bagi
        hasil = mangga % apel;

        Console.WriteLine($"Hasil {mangga} mod {apel} = {hasil}");
    }
}