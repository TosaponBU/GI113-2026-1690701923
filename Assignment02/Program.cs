/*
 * Student ID : 1690701923
 * Name       : Assignment02
 * Section    : 129C
 * No.        : 4
 * Course     : GI113 Computer Programming (GI)
 */

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Place = "Blacksmith shop";
            const double SmeltRate = 0.20;
            const double SalvageRate = 0.25;
            const int MaxBatch = 100;

            Console.WriteLine("<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>");


            Console.WriteLine("\n     ||                 ||      ");
            Console.WriteLine("     ||                 ||      ");
            Console.WriteLine(" ____||_________________||______");
            Console.WriteLine("| _____________________________ |");
            Console.WriteLine("||                  ______     ||");
            Console.WriteLine("||                 |      |    ||");
            Console.WriteLine("||    _____________|      |    ||");
            Console.WriteLine("||   |_____________|      |    ||");
            Console.WriteLine("||                 |      |    ||");
            Console.WriteLine("||                 |______|    ||");
            Console.WriteLine("||                * * * * *    ||");
            Console.WriteLine("||_____________________________||");
            Console.WriteLine("|_______________________________|");

            Console.WriteLine($"\nBlacksmith: WELLCOME to the: {Place}!");
            Console.WriteLine("Blacksmith: Do you want to smelt scrap or break down metal?");
            Console.WriteLine($"Blacksmith: And sorry, but we can't take more than {MaxBatch} pieces.");
            Console.Write("choose your decision (Y/N): ");
            char.TryParse(Console.ReadLine(), out char yesNo);
            if (yesNo == 'Y' || yesNo == 'y')
            {
                Console.WriteLine("\nBlacksmith: Would you like to smelt or breakdown?");
                Console.Write("Choose your menu (S/B) : ");
                char.TryParse(Console.ReadLine(), out char menu);
                if (menu == 'S' || menu == 's')
                {
                    Console.WriteLine("\nBlacksmith: Just let me know how many you have.");
                    Console.Write("How much should you give him (1-100) : ");
                    bool scrapValid = double.TryParse(Console.ReadLine(), out double scrapMount);
                    Console.WriteLine($"Scrap: {scrapMount} ---> Metal bar");
                    if (!scrapValid)
                    {
                        Console.WriteLine("\nBlacksmith: Only number sir.");
                    }
                    else if (scrapMount <= 0 || scrapMount > MaxBatch)
                    {
                        Console.WriteLine("\nBlacksmith: Sorry, we can only take between 1-100 pieces.");
                    }
                    else if (scrapMount > 0 && scrapMount <= MaxBatch)
                    {
                        double resultIngot = scrapMount * SmeltRate;
                        Console.WriteLine($"You received: {resultIngot:F2} metal bars.");
                    }
                }
                else if (menu == 'B' || menu == 'b')
                {
                    Console.WriteLine("\nBlacksmith: Just let me know how many you have. (1-100)");
                    Console.Write("How much should you give him: ");
                    bool metalValid = double.TryParse(Console.ReadLine(), out double metalMount);
                    Console.WriteLine($"Scrap: {metalMount} ---> Scrap");
                    if (!metalValid)
                    {
                        Console.WriteLine("\nBlacksmith: Only number sir.");
                    }
                    else if (metalMount <= 0 || metalMount > MaxBatch)
                    {
                        Console.WriteLine("\nBlacksmith: Sorry, we can only take between 1-100 pieces.");
                    }
                    else if (metalMount > 0 && metalMount <= MaxBatch)
                    {
                        double resultScrap = metalMount / SalvageRate;
                        Console.WriteLine($"You received: {resultScrap:F2} scraps.");
                    }
                }
                else
                {
                    Console.WriteLine("\nBlacksmith: Sorry, we donn't have other menu yet, just S or B ");
                }
            }
            else if (yesNo == 'N' || yesNo == 'n')
            {
                Console.WriteLine("\nBlacksmith: Please come back again later.");
            }
            else
            {
                Console.WriteLine("\nBlacksmith: Is it really that hard to just tell Y or S huh? Get out!!!");
            }

            Console.WriteLine("\n<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>:<:>");
        }
    }
}
