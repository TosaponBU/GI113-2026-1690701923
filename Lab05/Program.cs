namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game title, Sub-title
            Console.WriteLine("==>> MY GAME DEE <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calulattor\n");

            // Hero status input HP, ATK DEF
            Console.WriteLine("Hero Health");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster status in put
            Console.WriteLine("Monster Health");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.WriteLine("Monster Attack");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.WriteLine("Monster Defense");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // Input validation
            bool isHeroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonIntValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroIntValid}");
            Console.WriteLine($"MONSTER STATUS VALID: {isMonIntValid}");

            Console.WriteLine($"[HERO]        HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]     HP: {monHp} ATK: {monAtk} DEF: {monDef}");
            // bool allIntValid = ! isHeroIntValid && isMonIntValid;
            // ! ด้านหน้าคือ (จริง ---> เท็จ)

            // Compound assignment : += จำลองผู้เล่นใช้ potion
            int potionHeal = 8;
            //heroHp = heroHp + potionHeal;
            heroHp += potionHeal;
            Console.WriteLine($"\nHero drinks a potion, healing {potionHeal} HP. Hero HP now {heroHp} HP");

            // Arithmetic + การโจมตีธรรมดา
            int normDmg = Math.Max(0, heroAtk - monDef); // ดาเมจขึ้นอยุ่กับค่าป้องกัน
            Console.WriteLine($"\nNormal Attack would deal: {normDmg} DMG");

            // Precedence การโจมตีพิเศษ
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monDef);
            Console.WriteLine($"\nPower Attack would deal: {pwrDmg} DMG");

            //Random, simple percent of critical hit
            Random randomSometing = new Random();
            int roll = randomSometing.Next(1, 101); // +1 ค่ามากสุด
            bool isCrit = roll <= 10; // 10% Chance จาก 100
            int critDmg = normDmg + Convert.ToInt32(isCrit) * normDmg; // Bool 1 หรือ 0
            Console.WriteLine($"\nCritical hit roll: {roll} Critical: {isCrit}");
            Console.WriteLine($"If critical, normal attack would deal: {critDmg}");

        }
    }
}
