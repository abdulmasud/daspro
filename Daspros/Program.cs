/*
created by fadli rahman -NIM 2207112587
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
            const int hasilTambah = a + b + c;
            const int hasilKali = a * b * c;
            const int hasilKurang = a - b - c;
            const int hasilBagi = a / b / c;
            
            //menuliskan narasi
            Console.WriteLine("anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- password terdiri dari 4 angka");
            Console.WriteLine("- jika ditambahkan hasilnya "+hasilTambah);
            Console.WriteLine("- jika dikalikan hasilnya "+hasilKali);
            Console.WriteLine("- jika dikurangi hasilnya "+hasilKurang);
            Console.WriteLine("- jika dibagi hasilnya "+hasilBagi);
            Console.WriteLine("");
            Console.Write("enter code : ");

    }
    }
}
