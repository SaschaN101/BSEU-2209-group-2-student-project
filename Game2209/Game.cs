using System;
using System.Threading;

namespace Game2209
{
    public class Game
    {

        public void StartGame()
        {

        }
        public Player CreatePlayer(int player)
        {
            Console.WriteLine("Player " + player + ", enter name for the your fighter!");
            string playerName = Console.ReadLine();
            Console.WriteLine("AWESOME! Player " + playerName + " is created!\n\n");
            return new Player(playerName);
        }

        public void ShowHelloBanner()
        {
            Console.WriteLine("=============================   ____                      ____  ____   ___   ___   =============================");
            Console.WriteLine("=============================  / ___| __ _ _ __ ___   ___|___ \\|___ \\ / _ \\ / _ \\  =============================");
            Console.WriteLine("============================= | |  _ / _` | '_ ` _ \\ / _ \\ __) | __) | | | | (_) | =============================");
            Console.WriteLine("============================= | |_| | (_| | | | | | |  __// __/ / __/| |_| |\\__, | =============================");
            Console.WriteLine("=============================  \\____|\\__,_|_| |_| |_|\\___|_____|_____|\\___/   /_/  =============================");

            Console.WriteLine("\n\nWelcome to Game2209!");
            Console.WriteLine("================================================================================================================");
        }

        public void ChooseEquipment(Player player)
        {
            Console.WriteLine(player.Name + ", please, choose your equipment before fight");

            ConsoleKeyInfo KeyEquip, KeyLvl;
            Console.WriteLine("To choose equipment press keys:\nh (head)\nt (torso)\na (arms)\nl (legs)\nw (weapon)" +
                "\nPress q to exit");

            bool selectLevel(string equipment, string str2)
            {
                Console.WriteLine("\nYou have chosen " + equipment + ", now choose level of equipment\n"
                                    + "Press 1 (defence = 10), 2 (defence = 15) or 3 (defence = 20)");
                KeyLvl = Console.ReadKey();
                if (Validation.ValidationLevel(KeyLvl.KeyChar))
                {
                    switch (KeyLvl.KeyChar)
                    {

                        case '1': player.setDefenceLevelFor(str2, 1); break;
                        case '2': player.setDefenceLevelFor(str2, 2); break;
                        case '3': player.setDefenceLevelFor(str2, 3); break;
                        default: break;
                    }
                    Console.WriteLine("\nNow " + player.Name + "'s " + equipment + " defence = "
                        + player.getDefenceLevelFor(str2));
                    return false;
                }
                else
                {
                    Console.WriteLine("\nAn invalid parameter was entered. Try again.");
                    return true;
                }
            }

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
                                selectLevel("TORSO", "t");
                            }
                            break;
                        case 'a': //Arms
                            {
                                selectLevel("ARMS", "a");
                            }
                            break;
                        case 'l': //Legs
                            {
                                Console.WriteLine("\nYou have choosen LEGS, now choose level of equipment\n"
                                    + "Press 1 (defence = 5), 2 (defence = 10) or 3 (defence = 15)");
                                KeyLvl = Console.ReadKey();
                                switch (KeyLvl.KeyChar)
                                {
                                    case '1': player.setDefenceLevelFor("l", 1); break;
                                    case '2': player.setDefenceLevelFor("l", 2); break;
                                    case '3': player.setDefenceLevelFor("l", 3); break;
                                    default: break;
                                }
                                Console.WriteLine("\nNow " + player.Name + "'s LEGS defence = "
                                    + player.getDefenceLevelFor("l"));
                            }
                            break;
                        case 'w': //Weapon
                            {
                                Console.WriteLine("You have choosen WEAPON, now choose level of equipment\n"
                                    + "Press 1 (defence = 15), 2 (defence = 20) or 3 (defence = 25)");
                                KeyLvl = Console.ReadKey();
                                switch (KeyLvl.KeyChar)
                                {
                                    case '1': player.setDefenceLevelFor("w", 1); break;
                                    case '2': player.setDefenceLevelFor("w", 2); break;
                                    case '3': player.setDefenceLevelFor("w", 3); break;
                                    default: break;
                                }
                                Console.WriteLine("\nNow " + player.Name + "'s WEAPON damage = "
                                    + player.getDamageLevel());
                            }
                            break;
                        default: break;
                    }
                }
                else { Console.WriteLine("\nAn invalid parameter was entered. Try again."); }
            } while (KeyEquip.KeyChar != 'q');
        }

        public Player Fight(Player playerOne, Player playerTwo)
        {
            do
            {
                string AtkTargetP1, AtkTargetP2, DefTargetP1, DefTargetP2;

                double DamageToP1, DamageToP2, DefenceRatioP1 = 1, DefenceRatioP2 = 1;

                Console.WriteLine(playerOne.Name + " choose your attack target and defence target");
                AtkTargetP1 = Console.ReadLine(); AtkTargetP1 = AtkTargetP1.ToLower();
                DefTargetP1 = Console.ReadLine(); DefTargetP1 = DefTargetP1.ToLower();
                Console.WriteLine();

                Console.WriteLine(playerTwo.Name + " choose your attack target and defence target");
                AtkTargetP2 = Console.ReadLine(); AtkTargetP2 = AtkTargetP2.ToLower();
                DefTargetP2 = Console.ReadLine(); DefTargetP2 = DefTargetP2.ToLower();
                Console.WriteLine();

                int DamageP1 = playerOne.getDamageLevel(),
                    DamageP2 = playerTwo.getDamageLevel();

                int DefenceP1 = playerOne.getDefenceLevelFor(AtkTargetP2),
                    DefenceP2 = playerTwo.getDefenceLevelFor(AtkTargetP1);

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

                playerOne.reduceHealthPoints((int)DamageToP1);
                playerTwo.reduceHealthPoints((int)DamageToP2);

                Console.WriteLine("P1 dealt " + DamageToP2 + " damage to P2. \n" +
                    "P2 has " + playerTwo.HealthPoints + " health left.");
                Console.WriteLine("P2 dealt " + DamageToP1 + " damage to P1. \n" +
                    "P1 has " + playerOne.HealthPoints + " health left.\n");
            } while (playerOne.HealthPoints > 0 && playerTwo.HealthPoints > 0);

            if (playerOne.HealthPoints > 0 && playerTwo.HealthPoints <= 0)
                return playerOne;
            //Console.WriteLine(playerOne.Name + Constants.Win);
            else if (playerTwo.HealthPoints > 0 && playerOne.HealthPoints <= 0)
                return playerTwo;
            //Console.WriteLine(playerTwo.Name + Constants.Win);
            else
                //Console.WriteLine(Constants.Draw);
                return null;
        }

        public void CongratulateWinner(Player winner)
        {
            if (winner != null)
            {
                Console.WriteLine(winner.Name + Constants.Win);
            }
            else Console.WriteLine(Constants.Draw);
        }

        public void Countdown()
        {
            Console.WriteLine("\nPREPARE FOR BATTLE"); Thread.Sleep(1500); //задержка 1.5 сек
            Console.WriteLine(3); Thread.Sleep(1000);
            Console.WriteLine(2); Thread.Sleep(1000);
            Console.WriteLine(1); Thread.Sleep(1000);
            Console.WriteLine("..."); Thread.Sleep(1500);
            Console.WriteLine("START"); Thread.Sleep(1000);
        }
    }
}

