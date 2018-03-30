using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    class Program
    {
        private static int numbOfStuff = 0;
        private static Item []items;
        static void Main(string[] args)
        {
            float weight, value, damage, speed, effectLength, healthPerSecond, range;
            int usages, choice = 0;
            string name;

            
            while (true) {
                
                while (!(choice == 1 || choice == 2 || choice == 3)) {
                    Console.WriteLine("To create a new item, review inventory or exit enter '1','2' or '3':");
                    choice = Console.Read();
                }
                if (choice == 1)
                {
                    Console.WriteLine("Please enter the weight:");
                    weight = Console.Read();
                    Console.WriteLine("Please enter the value:");
                    value = Console.Read();
                    Console.WriteLine("Please enter the name:");
                    name = Console.ReadLine();
                    choice = 0;
                    while (!(choice == 1 || choice == 2))
                    {
                        Console.WriteLine("To create a sword enter '1' or to create a useable enter '2':");
                        choice = Console.Read();
                    }
                    if (choice == 1)
                    {
                        Console.WriteLine("Please enter the damage:");
                        damage = Console.Read();
                        Console.WriteLine("Please enter the speed");
                        speed = Console.Read();
                        items[numbOfStuff] = new Sword(
                            "             \\   /\r\n" +
                            "             |   |\r\n" +
                            ".__.         |   |_____________________________________________\r\n" +
                            "|  |_________|   |                                              \\\r\n" +
                            "|  |         |   |________________________________________________\\\r\n" +
                            "|  |_________|   |                                                /\r\n" +
                            "|__|         |   |_____________________________________________ /\r\n" +
                            "             |   |\r\n" +
                            "             |   |\r\n" +
                            "             /___\\"
                            , weight, value, name, damage, speed);
                    }
                    else
                    {
                        Console.WriteLine("Please enter number of usages:");
                        usages = Console.Read();
                        choice = 0;
                        while (!(choice == 1 || choice == 2))
                        {
                            Console.WriteLine("To create a potion enter '1' or to create a spear enter '2'");
                            choice = Console.Read();
                        }
                        if (choice == 1)
                        {
                            Console.WriteLine("Please enter the effect duration:");
                            effectLength = Console.Read();
                            Console.WriteLine("Please enter the health per second: ");
                            healthPerSecond = Console.Read();
                            items[numbOfStuff] = new Potion(
                                "     `.___,'\r\n" +
                                "      (___)\r\n" +
                                "      <   >\r\n" +
                                "       ) (\r\n" +
                                "      /`-.\\\r\n" +
                                "     /     \\\r\n" +
                                "    / _    _\\\r\n" +
                                "   :,' `-.' `:\r\n" +
                                "   |         |\r\n" +
                                "   :         ;\r\n" +
                                "    \\       /\r\n" +
                                "     `.___.' "
                                , weight, value, name, usages, effectLength, healthPerSecond);
                        }
                        else
                        {
                            Console.WriteLine("Please enter the damage:");
                            damage = Console.Read();
                            Console.WriteLine("Please enter the range:");
                            range = Console.Read();
                            items[numbOfStuff] = new ThrowingSpear(
                                "                                   _----..................___\r\n" +
                                 " __,,..,-====>       _,.--''------'' |   _____  ______________`''--._\r\n" +
                                 " \\      `\\   __..--''                |  /::: / /::::::::::::::\\      `\\\r\n" +
                                 "  \\       `''                        | /____/ /___ ____ _____::|    .  \\\r\n" +
                                 "   \\                           ,.... |            `    `     \\_|   ( )  |\r\n" +
                                 "    `.                       /`     `.\\ ,,''`'- ,.----------.._     `   |\r\n" +
                                 "      `.                     |        ,'       `               `-.      |\r\n" +
                                 "        `-._                 \\                                    ``.. /\r\n" +
                                 "            `---..............>"
                                 , weight, value, name, usages, damage, range);
                        }
                    }
                    numbOfStuff++;
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < numbOfStuff; i++)
                    {
                        Console.WriteLine(items[i].Image);
                    }
                }
                else {
                    break;
                }
            }
        }
    }
}
