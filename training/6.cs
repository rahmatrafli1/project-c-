using System;

class training6
{
    static void Main(string[] args)
    {
        int angka = 6;
        int hasilAngka = hitungKurangTiga(
            hitungKaliDua(
                hitungTambahLima(angka)
                )
            );

        Console.WriteLine("Hasil akhir angka : " + hasilAngka);
    }

    static int hitungTambahLima(int angka)
    {
        return angka + 5;
    }

    static int hitungKaliDua(int angka)
    {
        return angka * 2;
    }
    static int hitungKurangTiga(int angka)
    {
        return angka - 3;
    }
}