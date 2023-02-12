using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game2209
{
    class Validation
    {
        public bool isValid(string param)
        {
            return true;
        }

    }

    class Constants
    {
        public static string start = "Hello. Are you ready?";
        public static string start2 = "Accessible arg y is yes n if no";
        public static string notValid = "";


        public static string player(string name)
        {
            return "Player "+name+" is ready";
        }

    }

    class Program    
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.start);

            Person player1 = new Person("Liu Kang");
            Person player2 = new Person("Sub-Zero");

            Console.WriteLine(player1.ToString() + " is created!");
            Console.WriteLine(player2.ToString() + " is created!");

            Console.WriteLine(player1.ToString() + " please choose ur equipment");

            ConsoleKeyInfo KeyEquip, KeyLvl;
            Console.WriteLine(player1.ToString() + 
                " now you need to choose equipment before fight. \n" +
                "For choosing equipment press keys:\nh (head)\nt (torso)\na (arms)\nl (legs)\nw (weapon)" +
                "\nPress q to exit");
            do
            {
                KeyEquip = Console.ReadKey();
                switch (KeyEquip.KeyChar)
                {
                    case 'h': //Head
                        {
                            Console.WriteLine("\nYou have choose HEAD, now choose level of equipment\n"
                                + "Press 1 (defence = 10), 2 (defence = 15) or 3 (defence = 20)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player1.setDefenceLevelFor("h", 1); break;
                                case '2': player1.setDefenceLevelFor("h", 2); break;
                                case '3': player1.setDefenceLevelFor("h", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player1.ToString() + " HEAD defence = " 
                                + player1.getDefenceLevelFor("h"));
                        }
                              break;
                    case 't': //Torso
                        {
                            Console.WriteLine("\nYou have choose TORSO, now choose level of equipment\n"
                                + "Press 1 (defence = 10), 2 (defence = 15) or 3 (defence = 20)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player1.setDefenceLevelFor("t", 1); break;
                                case '2': player1.setDefenceLevelFor("t", 2); break;
                                case '3': player1.setDefenceLevelFor("t", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player1.ToString() + " TORSO defence = "
                                + player1.getDefenceLevelFor("t"));
                        }
                        break;
                    case 'a': //Arms
                        {
                            Console.WriteLine("\nYou have choose ARMS, now choose level of equipment\n"
                                + "Press 1 (defence = 5), 2 (defence = 10) or 3 (defence = 15)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player1.setDefenceLevelFor("a", 1); break;
                                case '2': player1.setDefenceLevelFor("a", 2); break;
                                case '3': player1.setDefenceLevelFor("a", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player1.ToString() + " ARMS defence = "
                                + player1.getDefenceLevelFor("a"));
                        }
                        break;
                    case 'l': //Legs
                        {
                            Console.WriteLine("\nYou have choose LEGS, now choose level of equipment\n"
                                + "Press 1 (defence = 5), 2 (defence = 10) or 3 (defence = 15)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player1.setDefenceLevelFor("l", 1); break;
                                case '2': player1.setDefenceLevelFor("l", 2); break;
                                case '3': player1.setDefenceLevelFor("l", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player1.ToString() + " LEGS defence = "
                                + player1.getDefenceLevelFor("l"));
                        }
                        break;
                    case 'w': //Weapon
                        {
                            Console.WriteLine("You have choose WEAPON, now choose level of equipment\n"
                                + "Press 1 (defence = 15), 2 (defence = 20) or 3 (defence = 25)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player1.setDefenceLevelFor("w", 1); break;
                                case '2': player1.setDefenceLevelFor("w", 2); break;
                                case '3': player1.setDefenceLevelFor("w", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player1.ToString() + " WEAPON damage = "
                                + player1.getDamageLevel());
                        }
                        break;
                    default: break;
                }
            } while (KeyEquip.KeyChar != 'q');

            Console.WriteLine("\n" + player2.ToString() +
                " now you need to choose equipment before fight. \n" +
                "For choosing equipment press keys:\nh (head)\nt (torso)\na (arms)\nl (legs)\nw (weapon)" +
                "\nPress q to exit");
            do
            {
                KeyEquip = Console.ReadKey();
                switch (KeyEquip.KeyChar)
                {
                    case 'h': //Head
                        {
                            Console.WriteLine("\nYou have choose HEAD, now choose level of equipment\n"
                                + "Press 1 (defence = 10), 2 (defence = 15) or 3 (defence = 20)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player2.setDefenceLevelFor("h", 1); break;
                                case '2': player2.setDefenceLevelFor("h", 2); break;
                                case '3': player2.setDefenceLevelFor("h", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player2.ToString() + " HEAD defence = "
                                + player2.getDefenceLevelFor("h"));
                        }
                        break;
                    case 't': //Torso
                        {
                            Console.WriteLine("\nYou have choose TORSO, now choose level of equipment\n"
                                + "Press 1 (defence = 10), 2 (defence = 15) or 3 (defence = 20)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player2.setDefenceLevelFor("t", 1); break;
                                case '2': player2.setDefenceLevelFor("t", 2); break;
                                case '3': player2.setDefenceLevelFor("t", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player2.ToString() + " TORSO defence = "
                                + player2.getDefenceLevelFor("t"));
                        }
                        break;
                    case 'a': //Arms
                        {
                            Console.WriteLine("\nYou have choose ARMS, now choose level of equipment\n"
                                + "Press 1 (defence = 5), 2 (defence = 10) or 3 (defence = 15)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player2.setDefenceLevelFor("a", 1); break;
                                case '2': player2.setDefenceLevelFor("a", 2); break;
                                case '3': player2.setDefenceLevelFor("a", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player2.ToString() + " ARMS defence = "
                                + player2.getDefenceLevelFor("a"));
                        }
                        break;
                    case 'l': //Legs
                        {
                            Console.WriteLine("\nYou have choose LEGS, now choose level of equipment\n"
                                + "Press 1 (defence = 5), 2 (defence = 10) or 3 (defence = 15)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player2.setDefenceLevelFor("l", 1); break;
                                case '2': player2.setDefenceLevelFor("l", 2); break;
                                case '3': player2.setDefenceLevelFor("l", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player2.ToString() + " LEGS defence = "
                                + player2.getDefenceLevelFor("l"));
                        }
                        break;
                    case 'w': //Weapon
                        {
                            Console.WriteLine("You have choose WEAPON, now choose level of equipment\n"
                                + "Press 1 (defence = 15), 2 (defence = 20) or 3 (defence = 25)");
                            KeyLvl = Console.ReadKey();
                            switch (KeyLvl.KeyChar)
                            {
                                case '1': player2.setDefenceLevelFor("w", 1); break;
                                case '2': player2.setDefenceLevelFor("w", 2); break;
                                case '3': player2.setDefenceLevelFor("w", 3); break;
                                default: break;
                            }
                            Console.WriteLine("\nNow " + player2.ToString() + " WEAPON damage = "
                                + player2.getDamageLevel());
                        }
                        break;
                    default: break;
                }
            } while (KeyEquip.KeyChar != 'q');

            do
            {
                string AtkTargetP1, AtkTargetP2, DefTargetP1, DefTargetP2;
                
                double DamageToP1, DamageToP2, DefenceRatioP1 = 1, DefenceRatioP2 = 1;
                    
                Console.WriteLine(player1.ToString() + " choose attack target " + player2.ToString() + " defence target");
                    AtkTargetP1 = Console.ReadLine(); AtkTargetP1 = AtkTargetP1.ToLower();
                    DefTargetP1 = Console.ReadLine(); DefTargetP1 = DefTargetP1.ToLower();
                Console.WriteLine();
                
                Console.WriteLine(player2.ToString() + " choose attack target " + player1.ToString() + " defence target");
                    AtkTargetP2 = Console.ReadLine(); AtkTargetP2 = AtkTargetP2.ToLower();
                    DefTargetP2 = Console.ReadLine(); DefTargetP2 = DefTargetP2.ToLower();
                Console.WriteLine();

                int DamageP1 = player1.getDamageLevel(), 
                    DamageP2 = player2.getDamageLevel();

                int DefenceP1 = player1.getDefenceLevelFor(AtkTargetP2),
                    DefenceP2 = player2.getDefenceLevelFor(AtkTargetP1);
                
                if (DefTargetP1 == AtkTargetP2)
                {
                    DefenceRatioP1 = 0.75;
                }
                if (DefTargetP2 == AtkTargetP1)
                {
                    DefenceRatioP2 = 0.75;
                }

                DamageToP1 = Math.Ceiling((DamageP2 - DefenceP1) * DefenceRatioP1);
                if (DamageToP1 <= 0) DamageToP1 = 0;
                DamageToP2 = Math.Ceiling((DamageP1 - DefenceP2) * DefenceRatioP2);
                if (DamageToP2 <= 0) DamageToP2 = 0;

                player1.reduceHealthPoints((int)DamageToP1);
                player2.reduceHealthPoints((int)DamageToP2);

                Console.WriteLine("P1 dealt " + DamageToP2 + " damage to P2. \n" +
                    "P2 has " + player2.HealthPoints + " health left.");
                Console.WriteLine("P2 dealt " + DamageToP1 + " damage to P1. \n" +
                    "P1 has " + player1.HealthPoints + " health left.\n");
            } while (player1.HealthPoints > 0 || player2.HealthPoints > 0);    
        }
    }
}
