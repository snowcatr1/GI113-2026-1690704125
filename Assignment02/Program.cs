/*
 * Student ID : 1690704125
 * Name       : Assignment02
 * Section    : 129D
 * No.        : 11
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string WhiteOre = "White";
            const double SmeltRate = 0.50;
            const double SalvageRate = 0.6;
            const double MaxBatch = 1000;

            Console.WriteLine("====- BLACKSMITH TIME -====");

            Console.WriteLine("\nSmelting 0.50/ Salvage 0.6");
            Console.WriteLine("Press S - Smelt (Ore -> Ingot)");
            Console.WriteLine("Press B - Breakdown (Ingot -> Ore)");

            Console.Write("\nChoose Menu: ");
            bool inputValid = char.TryParse(Console.ReadLine(), out char choice);

            Console.Write("How much would you like? ");
            bool amountValid = double.TryParse(Console.ReadLine(), out double amount);

            if (!inputValid || (choice != 'S' && choice != 's' && choice != 'B' && choice != 'b'))
            {
                Console.Write("Invalid menu input, please choose between S or B only");
            }

            else if (!amountValid || amount <= 0 || amount > MaxBatch)
            {
                Console.WriteLine("Invalid amount, please enter a number between 1-1000");
            }
            else if (choice == 'S' || choice == 's')
            {
                double result = amount * SmeltRate;
                Console.WriteLine($"{amount:F2} {WhiteOre} Ore = {result:F2} {WhiteOre} Ingot");
            }
            
            else
            {
                    double result = amount / SalvageRate;
                Console.WriteLine($"{amount:F2} {WhiteOre} Ingot = {result:F2} {WhiteOre} Ore");
            }

        }
    }
}