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
            const double SmeltRate = 0.15;
            const double SalvageRate = 0.2;
            const int MaxBatch = 100;

            Console.WriteLine($"WELLCOME to the: {Place}!");
            Console.WriteLine("Do you want to smelt or salvage some steel?");
            Console.WriteLine($"And sorry, We can't make you more than {MaxBatch} pieces.");
            Console.WriteLine("Y / N");
            bool inputValid = char.TryParse(Console.ReadLine(), out char yesNo);
            if (!inputValid)
            {
                Console.WriteLine("Is it really that hard to just reply with Y or S hah?");
                Console.WriteLine("Get out!");
                Console.WriteLine("You were kicked out of the shop...");
                Console.WriteLine("Please come back again later.");
            }
            else if (yesNo == 'Y' || yesNo == 'y')
            {
                
            }
            else if (yesNo == 'N' || yesNo == 'n')
            {

            }
            
        }
    }
}
