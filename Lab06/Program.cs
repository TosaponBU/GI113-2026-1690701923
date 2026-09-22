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

        }
    }
}
