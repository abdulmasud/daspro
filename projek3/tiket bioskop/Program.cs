using System;

namespace tiket_bioskop
{
    class Program
    {
        static void Main(string[] args)
        {
            String nama;
            int tahun, harga;
            Console.WriteLine("Nama : ");
            nama = Console.ReadLine();
            Console.WriteLine("Tahun Lahir : ");
            tahun = int.Parse(Console.ReadLine()); 
            if (2022-tahun < 10 || 2022-tahun > 60) {
                harga = 10000;
            } else {
                harga = 25000;
            }
            Console.WriteLine("|*******************************|");
            Console.WriteLine("{0,-8} {1,15} {2,8}", "|", "-- Studio 1 --","|"); 
            Console.WriteLine("{0,-8} {1,24}", "|Nama:", nama+"|");
            Console.WriteLine("{0,-8} {1,4} {2,19}", "|Harga:", "Rp",harga+".00|");
            Console.WriteLine("|-------------------------------|");
        }
    }
}
