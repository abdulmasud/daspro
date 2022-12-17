using System;

namespace ARRAY
{
    class Program
    {
        static char[,] TANK = {
            {' ','1','2','3','4','5'},
            {'1','~','~','~','~','~'},
            {'2','~','~','~','~','~'},
            {'3','~','~','~','~','~'},
            {'4','~','~','~','~','~'},
            {'5','~','~','~','~','~'}
        };
        static int[,] Jawaban = {
            {1,1},
            {3,3},
            {5,5}
        };
        static int[,] Recent = {
            {0,0},
            {0,0},
            {0,0}
        };
        static int[] Tebakan = {0,0};
        static int JawabanBenar = 0;
        static bool Mulai = true;
        static int Kebenaran = 0;

        static void Main(string[] args)
        {
            while(Mulai)
            {
                drawTank();
                try
                {
                    Console.Write("Pilih baris: "); Tebakan[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Pilih kolom: "); Tebakan[1] = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e){
                    Console.WriteLine("Error: Yang anda masukkan bukan angka valid");
                }
                Kebenaran = cekTank();
                if(Kebenaran == 2)
                {
                    Console.WriteLine("Sudah hancur!");
                }
                else
                if(Kebenaran == 1)
                {
                    Console.WriteLine("Boom! Tank hancur!");
                    JawabanBenar++;
                }
                else
                {
                    Console.WriteLine("Miss! Meleset!");
                }
                if(JawabanBenar >= 3)
                {
                    Console.WriteLine("\nMenang! Tank hancur semua!");
                    Mulai=false;
                }
                Console.WriteLine();
            }
        }

        static void drawTank()
        {
            for(int i=0;i<6;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.Write(TANK[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int cekTank()
        {
            for(int i=0;i<3;i++)
            {
                if(Recent[i,0] == Tebakan[0] && Recent[i,1] == Tebakan[1])
                {
                    return 2;
                }
            }
            for(int i=0;i<3;i++)
            {
                if(Jawaban[i,0] == Tebakan[0] && Jawaban[i,1] == Tebakan[1])
                {
                    TANK[Tebakan[0],Tebakan[1]] = 'X';
                    Recent[i,0] = Tebakan[0];
                    Recent[i,1] = Tebakan[1];
                    return 1;
                }
                else
                {
                    TANK[Tebakan[0],Tebakan[1]] = '0';
                }
            }
            return 0;
        }
    }
}