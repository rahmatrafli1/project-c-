using System;

class training4
{
    public static void Main(String[] args)
    {
        Console.Write("Jenis Kendaraan : ");
        string kendaraan = Console.ReadLine();

        Console.Write("Jenis Area : ");
        string area = Console.ReadLine();

        switch (kendaraan)
        {
            case "Mobil":
                Console.WriteLine("Kendaraan Mobil");
                switch (area)
                {
                    case "Jalan Raya":
                        Console.WriteLine("Area Cocok");
                        break;
                    case "Tanah":
                        Console.WriteLine("Area Tidak Cocok");
                        break;
                    case "Air":
                        Console.WriteLine("Area Tidak Cocok");
                        break;
                }
                break;
            case "Truk":
                Console.WriteLine("Kendaraan Motor");
                switch (area)
                {
                    case "Jalan Raya":
                        Console.WriteLine("Area Tidak Cocok");
                        break;
                    case "Tanah":
                        Console.WriteLine("Area Cocok");
                        break;
                    case "Air":
                        Console.WriteLine("Area Tidak Cocok");
                        break;
                }
                break;
            case "Kapal":
                Console.WriteLine("Kendaraan Kapal");
                switch (area)
                {
                    case "Jalan Raya":
                        Console.WriteLine("Area Tidak Cocok");
                        break;
                    case "Tanah":
                        Console.WriteLine("Area Tidak Cocok");
                        break;
                    case "Air":
                        Console.WriteLine("Area Cocok");
                        break;
                }
                break;
            default:
                Console.WriteLine("Kendaraan Tidak Terdeteksi");
                break;
        }
    }
}