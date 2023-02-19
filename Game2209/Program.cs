using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Game2209
{
         class Program    
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(Constants.start);

            Person player1 = new Person("Liu Kang");
            Person player2 = new Person("Sub-Zero");

            
            Console.WriteLine(player1.ToString() + " is created!");
            Console.WriteLine(player2.ToString() + " is created!");
            Console.WriteLine();

            Console.WriteLine(player1.ToString() + " please choose your equipment");

            ConsoleKeyInfo KeyEquip, KeyLvl;
           

            bool selectLevel(string equipment, string str2)
            {
                Console.WriteLine("\nYou have choose " + equipment + ", now choose level of equipment\n"
                                    + "Press 1 (defence = 10), 2 (defence = 15) or 3 (defence = 20)");
                KeyLvl = Console.ReadKey();
                if (Validation.ValidationLevel(KeyLvl.KeyChar))
                {
                    switch (KeyLvl.KeyChar)
                    {

                        case '1': player1.setDefenceLevelFor(str2, 1); break;
                        case '2': player1.setDefenceLevelFor(str2, 2); break;
                        case '3': player1.setDefenceLevelFor(str2, 3); break;
                        default: break;
                    }
                    Console.WriteLine("\nNow " + player1.ToString() + "  " + equipment + " defence = "
                        + player1.getDefenceLevelFor(str2));
                    return false;
                }else { Console.WriteLine("\nAn invalid parameter was entered. Try again.");
                    return true;
                }
            }


            ///player 1
            void SetSettingPlayer(Person player)
            {
                Console.WriteLine(player.ToString() +
                   " now you need to choose equipment before fight. \n" +
                   "For choosing equipment press keys:\nh (head)\nt (torso)\na (arms)\nl (legs)\nw (weapon)" +
                   "\nPress q to exit");

                do
                {
                    KeyEquip = Console.ReadKey();
                    if (Validation.ValidationEquipment(KeyEquip.KeyChar))
                    {
                        bool indicator = false;

                        switch (KeyEquip.KeyChar)
                        {
                            case 'h': //Head
                                {
                                    do
                                    {
                                        indicator = selectLevel("HEAD", "h");
                                    } while (indicator);
                                }
                                break;
                            case 't': //Torso
                                {
                                    do
                                    {
                                        indicator = selectLevel("TORSO", "t");
                                    } while (indicator);
                                }
                                break;
                            case 'a': //Arms
                                {
                                    do
                                    {
                                        indicator = selectLevel("ARMS", "a");
                                    } while (indicator);
                                }
                                break;
                            case 'l': //Legs
                                {
                                    do
                                    {
                                        indicator = selectLevel("LEGS", "l");
                                    } while (indicator);
                                }
                                break;
                            case 'w': //Weapon
                                {
                                    do
                                    {
                                        indicator = selectLevel("WEAPON", "w");
                                    } while (indicator);
                                }
                                break;
                            default: break;
                        }
                    }
                    else { Console.WriteLine("\nAn invalid parameter was entered. Try again."); }
                } while (KeyEquip.KeyChar != 'q');
                Console.WriteLine("\nDefault settings have been set for unspecified values\n");
            }

            SetSettingPlayer(player1);            
            SetSettingPlayer(player2);
           
            Constants.Countdown(); // �������� ������

            string attackRound()
            {
                bool isValid = false;
                string TargetP;
                do
                {
                    TargetP = Console.ReadLine();
                    TargetP = TargetP.ToLower();
                    isValid = !Validation.ValidationfightRaund(TargetP);
                    if (isValid) Console.WriteLine("An invalid parameter was entered. Try again.");

                } while (isValid);
                return TargetP;
            }

            do
            {
                string AtkTargetP1, AtkTargetP2, DefTargetP1, DefTargetP2;
                
                double DamageToP1, DamageToP2, DefenceRatioP1 = 1, DefenceRatioP2 = 1;
                    
                Console.WriteLine(player1.ToString() + " choose your attack target and defence target");

                AtkTargetP1 = attackRound();
                DefTargetP1 = attackRound();

                Console.WriteLine();
                Console.WriteLine(player2.ToString() + " choose your attack target and defence target");

                AtkTargetP2 = attackRound();
                DefTargetP2 = attackRound();

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
            } while (player1.HealthPoints > 0 && player2.HealthPoints > 0);

            if (player1.HealthPoints > 0 && player2.HealthPoints <= 0)
                Console.WriteLine(player1.ToString() + Constants.Win);
                    else if (player2.HealthPoints > 0 && player1.HealthPoints <= 0)
                        Console.WriteLine(player2.ToString() + Constants.Win);
                            else 
                                Console.WriteLine(Constants.Draw);
        }
    }
}
