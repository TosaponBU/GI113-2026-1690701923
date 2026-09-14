/*
 * Student ID : 1690701923
 * Name       : 
 * Section    : 129C
 * No.        : 4
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string idCard = "Soldier ID Card";
            var armyRank = "Sergeant";
            var charracterName = "Jone";
            var unit = '7';
            int height = 182;
            int weight = 78;
            int accuracy = 60;
            float missionSuccessRate = 88.50f;
            double performance = 69.9;
            bool isAlive = true;

            Console.WriteLine($"{idCard}");
            Console.WriteLine($"{armyRank} {charracterName}");
            Console.WriteLine($"Unit : {unit}");
            Console.WriteLine($"Height : {height}");
            Console.WriteLine($"Weight : {weight}");
            Console.WriteLine($"Accuracy : {accuracy}");
            Console.WriteLine($"Mission Success Rate : {missionSuccessRate}");
            Console.WriteLine($"Performance : {performance}");
            Console.WriteLine($"Alive : {isAlive}");

        }
    }
}
