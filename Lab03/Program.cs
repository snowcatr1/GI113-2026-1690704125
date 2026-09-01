/*
 * Student ID : 1690704125
 * Name       : Lab02
 * Section    : 129D
 * No.        : 11
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level {level} / {MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCrit Multipiler: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");

            // Implicit Conversation: currentHP (int) -->> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; //(double)currentHpDouble = (int)currentHp
            Console.WriteLine($"HP (double): {currentHpDouble}");


            // Explicit Conversion Cast attackPower (float) -->> int
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            

            // Cast vs. Convert critMultiplier (double) -->> int

        }
    }
}
