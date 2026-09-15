/*
 * Student ID : 1690704125
 * Name       : Lab05
 * Section    : 129D
 * No.        : 11
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("==>> MY VIDEO GAME VERY GOOD <<==");
            Console.WriteLine("Hero vs. Monster -- Fight Damage Calculator\n");

            // Hero stats input
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(),out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stats input
            Console.Write("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // Input validation / output
            bool heroStatValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monStatValid = monHpOk || monAtkOk || monDefOk;
            Console.WriteLine($"\nHERO STAT: {heroStatValid}");
            Console.WriteLine($"MONSTER STAT: {monStatValid}");

            Console.WriteLine($"[HERO] HP: {heroHp} ATK: {heroAtk} DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monHp} ATK: {monAtk} DEF: {monDef}");

            // bool allStatOk = heroStatValid && monStatValid

            // Compound Assign & Arithmetic (+) ผู้เล่นดื่มยาก่อนต่อสู้
            int potionHeal = 5;

            heroHp += potionHeal;            //1. แบบสั้น (แนะนำ) นำ HP Hero มา + กับ Potion
            //heroHp = Herohp + potionHeal;  //2. แบบยาว
            Console.WriteLine($"\nHero drinks a potion, heals {potionHeal} HP. Hero HP: {heroHp}");

            // NORMAL ATTACK Style combat ATK > DEF ถึงจะมี Damage ต่อศัตรู
            int normalDmg = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Hero would deals normal attack: {normalDmg}");

            // Power Attack
            int powerDmg = Math.Max(0, (heroAtk * 2) - monDef); // ใส่วงเล็บให้ทำก่อนได้
            Console.WriteLine($"Hero would deals power attack: {powerDmg}");

            // Random Critical Attack
            Random rng = new Random();
            int critRoll = rng.Next(1, 101); // อยากสุ่มโอกาศจาก 100%
            bool isCrit = critRoll <= 25; // 25% Chance of Critical

            int critDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg; // ถ้าอยากได้ x2
            Console.WriteLine($"Crit rool {critRoll}. Critical Hit: {isCrit}");
            Console.WriteLine($"If critical hit player would deal {critDmg} DMG!!");

        }
    }
}
