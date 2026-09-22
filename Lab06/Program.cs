/*
 * Student ID : 1690701923
 * Name       : Lab06
 * Section    : 129C
 * No.        : 4
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int lives = 1;

            if (lives <= 0) // ใส่เงื่อนไข ค่าที่ได้ต้องเป็น bool
            {
                Console.WriteLine("Game Over!"); //จะรันเมื่อ if เป็น true เท่านั้น
            }
            else
            {
                Console.WriteLine("Keep Fighting!");
            }

            //int level = 10;
            bool hasKey = false;
            Console.Write("Your level (1-99): ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int level);

            if (!inputValid || level < 1 || level > 99) //ให้เงื่อนไขข้อมูลผิด
            {
                Console.WriteLine("Invalid Level"); //เตือน
            }

            //ถ้าใช้หลายเงื่อนไข ให้เลขมากสุดอยู่ข้างบน (เช็คมาก -> น้อย)
            if (level >= 10 ) //เงื่อนไข 1 
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5) //เงื่อนไข 2 จะรันถ้าไม่ตรงเงื่อนไข 1
            {
                if (hasKey == true)
                {
                    Console.WriteLine("The door opens.");
                }
                else
                {
                    Console.WriteLine("Locked, Find the key.");
                }
            }
            else
            {
                Console.WriteLine("Cann't open the door.");
            }

            bool isPoisoned = true;
            if (isPoisoned)
            {
                Console.WriteLine("You Died");
            }
            else if (!isPoisoned)
            {
                Console.WriteLine("You Lives");
            }
            */

            Console.WriteLine("Your found a zombie, Think if you donn't wanna die!");
            Console.WriteLine("So badddd, You gun magazine is empty");
            Console.WriteLine("Choice 1 : Reload magazine.");
            Console.WriteLine("Choice 2 : Just shoot damn it.");
            Console.WriteLine("Choice 3 : Kang fo kick!");

            Console.WriteLine("Chose your decision: ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int choice);
            if (!inputValid || choice < 1 || choice > 3)
            {
                Console.WriteLine("Donn't have another change, You dead.");
            }

            else if (choice == 1)
            {
                Console.WriteLine("Now you have a full ammo, What you do next.");
                Console.WriteLine("Choice 1 : Pull the trigger.");
                Console.WriteLine("Choice 2 : Aim calmly.");

                Console.WriteLine("Chose your decision: ");
                bool inputValid01 = int.TryParse(Console.ReadLine(), out int choice02);
                if (!inputValid01 || choice02 < 1 || choice02 > 2)
                {
                    Console.WriteLine("Think fast! Now you dead");
                }
                else if (choice02 == 1)
                {
                    Console.WriteLine("Grrrrr! Grrrrr!, You just drum mag and now zombie look like beehive.");
                    Console.WriteLine("Phewww, you survive this day.");
                }
                else if (choice02 == 2)
                {
                    Console.WriteLine("The man who waits for the perfect shot dies with a full magazine.");
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("Click! Click! Guest what?");
                Console.WriteLine("You dead.");
            }

            else if (choice == 3)
            {
                Console.WriteLine("You aren't Bruce Lee");
                Console.WriteLine("You dead.");
            }
        }
    }
}
