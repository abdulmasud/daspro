/* m abdul mas`ud 2207235765
*/
using System;

namespace Programdadu
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int musuhRandomNum;

            int playerPoints = 0;
            int musuhPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ronde "+(i+1));
                Console.WriteLine("tekan tombol apa saja untuk melempar dadu");
                
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("kamu mengocok " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                musuhRandomNum = random.Next(1, 7);
                Console.WriteLine("Musuh mengocok " + musuhRandomNum);

                if(playerRandomNum > musuhRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player memenangkan ronde ini!");
                }
                else if(playerRandomNum < musuhRandomNum)
                {
                    musuhPoints++;
                    Console.WriteLine("musuh memenangkan ronde ini!");
                }
                else
                {
                    Console.WriteLine("Imbang!");
                }

                Console.WriteLine("skornya sekarang - Player : " + playerPoints + ". Musuh : " + musuhPoints + ".");
                Console.WriteLine();
            }

            if(playerPoints > musuhPoints)
            {
                Console.WriteLine("kamu menang!");
            }
            else if(playerPoints < musuhPoints)
            {
                Console.WriteLine("kamu kalah");
            }
            else
            {
                Console.WriteLine("itu seri!");
            }

            Console.ReadKey();
        }
    }
}