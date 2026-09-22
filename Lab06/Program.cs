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

            /*
             You found zombie!
             Sadly, You donn't have any ammo in magazine...
             choose you decision

                1.Wait! Lemme reload.
                Now you have full ammo in magazine.
                What are you do next.
                        1.1 Pull the trigger asap!
                               Rat-a-tat-tat Rat-tat-tat, Now zombie look like a beehive...
                               You well done.
                        1.2 Calmly aim.
                               The man who waits for the perfect shot dies with a full magazine...
                               You dead.

                2.Just shoot damn it!
                Click! Click, Guest what?
                You dead.

                3.Pick up sashimi knife.
                        3.1 Stab
                                Crunch!
                        It’s almost dead. Just one more hit.
                        3.2 Throw
                                Miss!
                                Sorry,You don't have a single ninja in your bloodline...
                                You dead.

                4.Kang fu.
                        4.1 You're not even Bruce Lee...
                        4.2 Woah how you do that!
                            Zombie heah roll on the ground.
                            Looks like luck is on your side today, You well done.
            */

            int zombieHp = 10;
            int knifeAtk = 5;

            Console.WriteLine("You found zombie!");
            Console.WriteLine("Sadly, You donn't have any ammo in magazine...");
            Console.WriteLine("Go, Choose you decision.");
            Console.WriteLine("1. Wait! Lemme reload.");
            Console.WriteLine("2. Just shoot damn it!");
            Console.WriteLine("3. Pick up sashimi knife.");
            Console.WriteLine("4. Kang fu.");
            Console.Write("\nChoose your decision (1-4): ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int mainChoice);
            if (!inputValid || mainChoice < 1 || mainChoice > 4)
            {
                Console.WriteLine("\nDonn't have another change...");
                Console.WriteLine("You dead.");
            }
            else if (mainChoice == 1)
            {
                Console.WriteLine("Now you have full ammo in magazine.");
                Console.WriteLine("What are you do next.");
                Console.WriteLine("1. Pull the trigger ASAP!");
                Console.WriteLine("2. Calmly aim.");
                Console.Write("\nChoose your decision (1-2): ");
                bool inputValid01 = int.TryParse(Console.ReadLine(), out int sideChoice01);
                if (!inputValid01 || sideChoice01 < 1 || sideChoice01 > 2)
                {
                    Console.WriteLine("\nDonn't have another change...");
                    Console.WriteLine("You dead.");
                }
                else if (sideChoice01 == 1)
                {
                    Console.WriteLine("Rat-a-tat-tat! Rat-tat-tat!");
                    Console.WriteLine("Now zombie look like a beehive...");
                    Console.WriteLine("You well done.");
                }
                else if (sideChoice01 == 2)
                {
                    Console.WriteLine("\nThe man who waits for the perfect shot dies with a full magazine...");
                    Console.WriteLine("You dead.");
                }
            }

            else if (mainChoice == 2)
            {
                Console.WriteLine("\nClick! Click, Guest what?");
                Console.WriteLine("You dead.");
            }

            else if (mainChoice == 3)
            {
                Console.WriteLine("what are you gonna do");
                Console.WriteLine("1. Stab.");
                Console.WriteLine("2. Throw knife.");
                Console.Write("\nChoose your decision (1-2): ");
                bool inputValid03 = int.TryParse(Console.ReadLine(), out int sideChoice03);
                if (sideChoice03 == 1)
                {
                    zombieHp -= knifeAtk;
                    if (zombieHp > 0)
                    {
                        Console.WriteLine("There's no way to kill it...");
                        Console.WriteLine("You dead.");
                    }
                    else if (zombieHp <= 0)
                    {
                        Console.WriteLine("\nZombie head rolled on the floor,And blood splattered all over the room.");
                        Console.WriteLine("You well done.");
                    }
                }
                else if (sideChoice03 == 2)
                {
                    Random randomCrit = new Random();
                    int roll = randomCrit.Next(1, 4);
                    bool crit = roll == 1;
                    Console.WriteLine($"A 1/3 chance, and you got: {roll}");
                    if (crit)
                    {
                        Console.WriteLine("Looks like luck is on your side today.");
                        Console.WriteLine("You well done.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have a single ninja in your bloodline sir.");
                        Console.WriteLine("Now you dead.");
                    }
                }
            }

            else if (mainChoice == 4)
            {
                Console.WriteLine("What!? You not even Bruce Lee.");
                Console.WriteLine("Now you dead.");
            }
        }
    }
}
