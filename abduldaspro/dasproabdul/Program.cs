/*
created by abdul mas`ud -NIM 2207135765
*/
using System;

namespace Daspro 
{
    class Program
    {
        //Main method
        static void Main(string[] args)
        {
            //Deklarasi variabel
            const int a = 5;
            const int b = 4;
            const int c = 7;

            //narasi variabel
            const int Tambah = a + b + c;
            const int Kali = a * b * c;
            const int Kurang = a - b - c;
            const int Bagi = a / b / c;
            
            //menuliskan narasi
            Console.WriteLine("anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- password terdiri dari 4 angka");
            Console.WriteLine("- jika ditambahkan hasilnya "+Tambah);
            Console.WriteLine("- jika dikalikan hasilnya "+Kali);
            Console.WriteLine("- jika dikurangi hasilnya "+Kurang);
            Console.WriteLine("- jika dibagi hasilnya "+Bagi);
            Console.WriteLine("");
            Console.Write("enter code : ");

    }
    }
}
