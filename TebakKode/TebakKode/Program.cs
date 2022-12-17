using System;

namespace TebakKode
{
    class Program
    {
        //deklarasi variabel yang akan digunakan
        static int kodeA, kodeB, kodeC, hasilA, hasilB, level, nyawa;
        static String tebakanA, tebakanB, tebakanC;
        static bool gameover, cekBenar;

        //Main method (gerbang utama)
        static void Main(string[] args)
        {
            //inisialisasi variabel penting
            Inisial();

            //loop game
            while(nyawa > 0 && level <= 5) //saat nyawa lebih dari 0, dan level masih 5 kebawah, game berjalan
            {
                //Cek kebenaran jawaban
                cekBenar = Play(level);

                //Jika benar menjawab
                if(cekBenar)
                {
                    //level ditambah
                    level += 1;
                    Console.WriteLine("Levelmu naik bro, jadi level "+level);
                }
                else
                {
                    //jika salah, nyawa berkurang
                    nyawa -= 1;
                    Console.WriteLine("Nyawamu kurang broo, jadi "+nyawa+" nyawamu.");
                }
                
                //jika level sudah mencapai 5 dan nyawa masih ada
                if(nyawa > 0 && level > 5)
                {
                    Console.WriteLine("Menang cuyyy! Level abiss. Hebat bet luhh..");
                    gameover = true;
                }
                else if(nyawa <= 0 && level != 1) //jika nyawa habis, tapi sudah bisa menjawab
                {
                    Console.WriteLine("Game over! Nyawa abis. Coba lagi cuyy..");
                    Console.WriteLine("Lu udah jawab sampe level "+ (level - 1));
                    gameover = true;
                }
                else if(nyawa <= 0 && level == 1) //jika nyawa habis, tapi tidak bisa menjawab
                {
                    Console.WriteLine("Kalah! Nyawa abis. Lu gabisa jawab..");
                    gameover = true;
                }

                //Jika gameover true, akhiri loop
                if(gameover)
                {
                    break;
                }
            }

            //exit
            Console.WriteLine("\nPress any key"); Console.ReadKey();
        }

        //menginisialisasi variabel penting
        static void Inisial()
        {
            level = 1;
            nyawa = 3;
            gameover = false;
            cekBenar = false;
        }

        static bool Play(int lvl)
        {
            //menginisialisasi random untuk mencari kode
            Random rng = new Random();

            //cari kode random berdasarkan level
            kodeA = rng.Next(1,lvl+1);
            kodeB = rng.Next(1,lvl+1);
            kodeC = rng.Next(1,lvl+1);
            /*
            misal, level = 1
            1 + 1 = 2
            Next(1,2) = (1,2)
            misal, level = 2
            2 + 1 = 3
            Next(1,3) = (1,2,3)
            */

            //menginisialisasi bantuan player
            hasilA = kodeA + kodeB + kodeC;
            hasilB = kodeA * kodeB * kodeC;

            //Intro
            Console.WriteLine("Halo!");
            Console.WriteLine("Coba Tebak!");
            Console.WriteLine("- Kode terdiri dari 3 angka");
            Console.WriteLine("- Jika ditambah, maka " + hasilA);
            Console.WriteLine("- Jika dikali, maka " + hasilB);
            
            //tebak
            Console.Write("Kode A: "); tebakanA = Console.ReadLine();
            Console.Write("Kode B: "); tebakanB = Console.ReadLine();
            Console.Write("Kode C: "); tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda: " + tebakanA + " " + tebakanB + " " + tebakanC + " ?");

            //Cek kebenaran menggunakan if
            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
            {
                Console.WriteLine("Anjay benarrrrr...");

                //jika benar, return true
                return true;
            }
            else
            {
                Console.WriteLine("Salah anjirrr...");

                //jika salah, return false
                return false;
            }
        }
    }
}
