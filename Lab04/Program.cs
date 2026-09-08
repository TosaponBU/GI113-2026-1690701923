/*
 * Student ID : 1690701923
 * Name       : Lab04
 * Section    : 129C
 * No.        : 4
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");

            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOK = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOK = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOK = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOK}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOK = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOK}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOK = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"valid input: {slotOK}");
            Console.WriteLine($"Slot: {slot}");


            /*
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");

            Console.Write("Name your hero: "); // พิพม์ต่อบรรทัดเดิม
            Console.Write(">>> ");
            string playerName = Console.ReadLine(); // รับ input --> string
            Console.WriteLine($"\n\"Welcome, {playerName}. Your journey begins...\"");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      DIFFICULTY SELECT       |");
            Console.WriteLine("+------------------------------+");

            Console.Write("Choose your difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\"Difficuty{difficulty} selected. good luck out there");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");

            Console.Write("How many potion? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");
            
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");

            Console.Write("Name your charater: ");
            string charName = Console.ReadLine();
            Console.Write("Choose your class (1-3): ");
            bool classOK = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-1.0): ");
            bool luckOK = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n\"{charName} the Class-{classNum} adventurer enters ther dungeon. Luck: {luck}");
            */

        }
    }
}
