using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] truth = {false, false}; //0 = salah, 1 = benar
            int state = 1;

            string[] bankKata = new string[10]{
             "masjid",
             "mimbar",
             "ampli",
             "mic",
             "meja",
             "kursi",
             "sajadah",
             "quran",
             "kitab",
             "keset"
            };
            int nyawa = 0; 

            Random random = new Random();
            string MisteriKata = bankKata[random.Next(0, 10)];
            char[] tebakan = new char[MisteriKata.Length];

            Console.Clear();
            for (int p = 0; p < MisteriKata.Length; p++) {
                tebakan[p] = '_';
            }

            while (state == 1)
            {
                Console.Write("Gues letters : ");
                string input = Console.ReadLine();
                if(input == "")
                {
                    continue;
                }
                for (int j = 0; j < MisteriKata.Length; j++)
                {
                    if (input[0] == MisteriKata[j])
                    {
                        truth[1] = true;
                        tebakan[j] = input[0];
                    }
                    else if (j == MisteriKata.Length - 1 && truth[1] == false)
                    {
                        truth[0] = true;
                    }
                }

                Console.Clear();

                if (truth[0] == true) {
                    Console.WriteLine("Your guess is wrong!");
                    nyawa++;
                    truth[0] = false;
                }
                truth[1] = false;
                Console.WriteLine(tebakan);
                Console.WriteLine();
                if(nyawa == 1)
                {
                    Console.WriteLine("_|___");
                }
                else if(nyawa == 2)
                {
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|___");
                }
                else if(nyawa == 3)
                {
                    Console.WriteLine(" |/");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|___");
                }
                else if(nyawa == 4)
                {
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|___");
                }
                else if(nyawa == 5)
                {
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|___");
                }
                else if(nyawa == 6)
                {
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|___");
                }
                else if(nyawa == 7)
                {
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |      \\|/");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|___");
                }
                else if(nyawa == 8)
                {
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |      \\|/");
                    Console.WriteLine(" |       |");
                    Console.WriteLine(" |");
                    Console.WriteLine("_|___");
                }
                else if(nyawa == 9)
                {
                    Console.WriteLine("__________");
                    Console.WriteLine(" |/      |");
                    Console.WriteLine(" |      (_)");
                    Console.WriteLine(" |      \\|/");
                    Console.WriteLine(" |       |");
                    Console.WriteLine(" |      / \\");
                    Console.WriteLine("_|___");
                }

                string str = new String(tebakan);
                if (str == MisteriKata) {
                    Console.WriteLine("Congratulations, you wind!");
                    state = 0;
                } else if (nyawa == 10 && str != MisteriKata) { 
                    Console.WriteLine("Try again!");
                    state = 0;
                }
            }
        }
    }
}
