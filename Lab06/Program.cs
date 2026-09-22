/*
 * Student ID : 1690704125
 * Name       : Lab06
 * Section    : 129D
 * No.        : 11
 * Course     : GI113 Computer Programming (GI)
 */
using System.ComponentModel.Design;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int lives = 0;

            // เรียก if เพื่อเช็คเงื่อนไข
            //if (lives <= 0) //ในวงเล็บคือเงื่อนไขที่เป็น bool
            //{
            //ในปีกกาเป็นโค๊ตการทำงาน จะรันเมื่อได้ true
            //    Console.WriteLine("Game Over");
            //}
            // else
            // {
            //     Console.WriteLine("Game is Playing");
            // }

            //โค๊ดบรรทัดต่อไปจะทำงานเมื่อ if ทำเสร็จ หรือ โดนข้าม (false)
            //Console.WriteLine("Continue Code");

            //int level = 10;
            //bool hasKey = true;
            //Console.Write("Youe level (1-99): = ");
            //bool inputValid = int.TryParse(Console.ReadLine(), out int level);

            //if (!inputValid || level < 1 || level > 99) //เงื่อนไขที่ถือว่า error จาก input
            // {
            //     Console.WriteLine("Invalid Level.");
            // }
            //else if (level >= 10 && hasKey) //เมื่อมีเงื่อนไขเป็นจำนวน ให้เรียงเช็คจำนวน มาก -> น้อย เสมอ
            //{
            //    Console.WriteLine("Boss floor unlocked.");
            //}
            //else if (level >= 5)
            //{
            //    if (hasKey)
            //   {
            //      Console.WriteLine("The door opens.");
            //  }
            //  else
            //  {
            //      Console.WriteLine("Locked, Find a key.");
            //  }
            // }
            // else
            //{
            //   Console.WriteLine("The door stays shut.");
            // }

            //bool isPoisoned = true;

            // เรียก bool เฉยๆ คือเช็คว่าเป็นจริงไหม
            //if (isPoisoned == true)
            //{
            //     Console.WriteLine("You died!");
            //}
            //else if (isPoisoned == false) // ! คือตรงข้ามกับ true -> false, false -> true
            //{
            //    Console.WriteLine("You lives");
            //}

            int scratchDmg = 10;
            int biteDmg = 25;
            int corruptedcatHp = 50;
            

            Console.WriteLine("GAME TITLE: HERO CAT ADVENTURE");

            Console.WriteLine("Action 1: Scratch");
            Console.WriteLine("Action 2: Bite");
            Console.WriteLine("Action 3: Run Away");

            Console.Write("CHOOSE YOUR NEXT MOVE (1-3): ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputValid || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input, plese choose between 1-3 only!");
            }
            else if (choice == 1)
            {
                corruptedcatHp -= scratchDmg;
                if (corruptedcatHp <= 0)
                {
                    Console.WriteLine($"Corrupted Cat took damage from Scratch, took {scratchDmg} DMG. Corrupted Cat died!.");
                }
                else
                {
                    Console.WriteLine($"Corrupted Cat took damage from Scratch, took {scratchDmg} DMG. Corrupted Cat has {corruptedcatHp} HP left.");
                }

            }
            else if (choice == 2)
            {
                corruptedcatHp -= biteDmg;
                if (corruptedcatHp <= 0)
                {
                    Console.WriteLine($"Corrupted Cat is hit by Bite, took {biteDmg} DMG. Corrupted Cat died!.");
                }
                else
                {
                    Console.WriteLine($"Corrupted Cat is hit by Bite, took {biteDmg} DMG. Corrupted Cat has {corruptedcatHp} HP left.");
                }
            }
            else if (choice == 3)
            {
                Console.Write($"The Hero Cat ran away.");
            }


            }
        }
    }

