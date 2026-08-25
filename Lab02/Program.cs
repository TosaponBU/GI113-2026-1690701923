/*
 * Student ID : 1690701923
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            //ประกาศตัวแปร 6 ตัว
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier : {critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");

            Console.WriteLine();
            //คำนวนตัวแปร
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin take 60 damage!");
            Console.WriteLine();
            //ลด HP 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"HP {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent : {hpPercent}%");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("==== Flower List ====");
            string flowerName1 = "Rose";
            int relationshipTool1 = 1;
            char rarity1 = 'C';
            Console.WriteLine($"Flower: {flowerName1}");
            Console.WriteLine($"Relationship poit: {relationshipTool1}");
            Console.WriteLine($"Rarity: {rarity1}");
            string flowerName2 = "Sunflower";
            int relationshipTool2 = 5;
            char rarity2 = 'S';
            Console.WriteLine($"Flower: {flowerName2}");
            Console.WriteLine($"Relationship poit: {relationshipTool2}");
            Console.WriteLine($"Rarity: {rarity2}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("==== Character ====");
            string name1 = "Emma";
            string personality1 = "Friendly";
            string gender1 = "Female";
            bool status1 = true;
            int currentRelationship1 = 6;
            int maxRelationship1 = 10;
            int high1 = 168;
            int weight1 = 46;
            float str1 = 12.5f;
            float int1 = 47.5f;
            double monney1 = 46.6666;
            Console.WriteLine($"Name: {name1}");
            Console.WriteLine($"Personality: {personality1}");
            Console.WriteLine($"Gender: {gender1}");
            Console.WriteLine($"Can make relation: {status1}");
            Console.WriteLine($"Relationship: {currentRelationship1}/{maxRelationship1}");
            Console.WriteLine($"High: {high1} Weight: {weight1}");
            Console.WriteLine($"STR: {str1} INT: {int1}");
            Console.WriteLine($"Have monneys: {monney1}$");
            Console.WriteLine($"Give Rose -----> {currentRelationship1 + relationshipTool1 }/{maxRelationship1}");
            Console.WriteLine();

            string name2 = "Linda";
            string personality2 = "Strict";
            string gender2 = "Female";
            bool status2 = true;
            int currentRelationship2 = 1;
            int maxRelationship2 = 10;
            int high2 = 178;
            int weight2 = 70;
            float str2 = 32.5f;
            float int2 = 50.5f;
            double monney2 = 102.2222;
            Console.WriteLine($"Name: {name2}");
            Console.WriteLine($"Personality: {personality2}");
            Console.WriteLine($"Gender: {gender2}");
            Console.WriteLine($"Can make relation: {status2}");
            Console.WriteLine($"Relationship: {currentRelationship2}/{maxRelationship2}");
            Console.WriteLine($"High: {high2} Weight: {weight2}");
            Console.WriteLine($"STR: {str2} INT: {int2}");
            Console.WriteLine($"Have monneys: {monney2}$");
            Console.WriteLine($"Give Rose -----> {currentRelationship2 + relationshipTool1}/{maxRelationship2}");
            Console.WriteLine();

            string name3 = "Roy";
            string personality3 = "Energetic";
            string gender3 = "Male";
            bool status3 = true;
            int currentRelationship3 = 8;
            int maxRelationship3 = 10;
            int high3 = 172;
            int weight3 = 56;
            float str3 = 20.5f;
            float int3 = 35.5f;
            double monney3 = 29.9999;
            Console.WriteLine($"Name: {name3}");
            Console.WriteLine($"Personality: {personality3}");
            Console.WriteLine($"Gender: {gender3}");
            Console.WriteLine($"Can make relation: {status3}");
            Console.WriteLine($"Relationship: {currentRelationship3}/{maxRelationship3}");
            Console.WriteLine($"High: {high3} Weight: {weight3}");
            Console.WriteLine($"STR: {str3} INT: {int3}");
            Console.WriteLine($"Have monneys: {monney3}$");
            Console.WriteLine($"Give Sunflower -----> {currentRelationship3 + relationshipTool2}/{maxRelationship3}");
            Console.WriteLine();

            string name4 = "Tyler";
            string personality4 = "Irritable";
            string gender4 = "Male";
            bool status4 = true;
            int currentRelationship4 = 0;
            int maxRelationship4 = 10;
            int high4 = 192;
            int weight4 = 88;
            float str4 = 79.5f;
            float int4 = 12.5f;
            double monney4 = 0.00012;
            Console.WriteLine($"Name: {name4}");
            Console.WriteLine($"Personality: {personality4}");
            Console.WriteLine($"Gender: {gender4}");
            Console.WriteLine($"Can make relation: {status4}");
            Console.WriteLine($"Relationship: {currentRelationship4}/{maxRelationship4}");
            Console.WriteLine($"High: {high4} Weight: {weight4}");
            Console.WriteLine($"STR: {str4} INT: {int4}");
            Console.WriteLine($"Have monneys: {monney4}$");
            Console.WriteLine($"Give Sunflower -----> {currentRelationship4 + relationshipTool2}/{maxRelationship4}");

        }
    }
}
