/*
 * Student ID : 1690704125
 * Name       : Lab02
 * Section    : 129D
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

            //Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");

            //Lab02 Part B
            string sphynxName = "Luna";
            char sphynxhealthyRank = 'A';
            int sphynxHungry = 20;
            double sphynxSleepy = 50;
            bool sphynxHappy = true;

            string persianName = "Pearl";
            char persianhealthyRank = 'A';
            int persianHungry = 23;
            float persianSpeed = 8.2f;
            bool persianHappy = true;

            string mainecoonName = "Ruby";
            char mainecoonhealthyRank = 'A';
            int mainecoonHungry = 20;
            float mainecoonSpeed = 7.5f;
            bool mainecoonHappy = true;

            string britishshorthairName = "Lucky";
            char britishshorthairhealthyRank = 'A';
            int britishshorthairHungry = 20;
            float britishshorthairSpeed = 7.4f;
            bool britishshorthairHappy = true;

            Console.WriteLine("===== CAT LIST =====");

            Console.WriteLine("----- SPHYNX -----");
            Console.WriteLine($"Name: {sphynxName}");
            Console.WriteLine($"Healthy: {sphynxhealthyRank}");
            Console.WriteLine($"Hungry: {sphynxHungry}");
            Console.WriteLine($"Sleepy: {sphynxSleepy}");
            Console.WriteLine($"Is Happy: {sphynxHappy}");

            Console.WriteLine("----- PERSIAN -----");
            Console.WriteLine($"Name: {persianName}");
            Console.WriteLine($"Healthy: {persianhealthyRank}");
            Console.WriteLine($"Hungry: {persianHungry}");
            Console.WriteLine($"Speed: {persianSpeed}");
            Console.WriteLine($"Is Happy: {persianHappy}");

            Console.WriteLine("----- MAINE COON -----");
            Console.WriteLine($"Name: {mainecoonName}");
            Console.WriteLine($"Healthy: {mainecoonhealthyRank}");
            Console.WriteLine($"Hungry: {mainecoonHungry}");
            Console.WriteLine($"Speed: {mainecoonSpeed}");
            Console.WriteLine($"Is Happy: {mainecoonHappy}");

            Console.WriteLine("----- BRITISH SHORTHAIR -----");
            Console.WriteLine($"Name: {britishshorthairName}");
            Console.WriteLine($"Healthy: {britishshorthairhealthyRank}");
            Console.WriteLine($"Hungry: {britishshorthairHungry}");
            Console.WriteLine($"Speed: {britishshorthairSpeed}");
            Console.WriteLine($"Is Happy: {britishshorthairHappy}");


        }
    }
}