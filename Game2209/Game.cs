using System;
using System.Threading;

namespace Game2209
{
    public class Game
    {
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

        public Player CreatePlayer(int player)
        {
            Console.WriteLine(string.Format(Constants.NameSelectionText, player));
            string playerName = Console.ReadLine();
            Console.WriteLine(Constants.NameSelectedText, playerName);
            return new Player(playerName);
        }

        private bool SelectLevel(string equipment, string str2, Player player)
        {
            ConsoleKeyInfo KeyLvl;
            Console.WriteLine("\nYou have chosen " + equipment + ", now choose level of equipment\n"
                                + "Press 1 (defence = 10), 2 (defence = 15) or 3 (defence = 20)");
            KeyLvl = Console.ReadKey();
            if (Validation.ValidationLevel(KeyLvl.KeyChar))
            {
                switch (KeyLvl.KeyChar)
                {

                    case '1': player.SetDefenceLevelFor(str2, 1); break;
                    case '2': player.SetDefenceLevelFor(str2, 2); break;
                    case '3': player.SetDefenceLevelFor(str2, 3); break;
                    default: break;
                }
                Console.WriteLine("\nNow " + player.Name + "'s " + equipment + " defence = "
                    + player.GetDefenceLevelFor(str2));
                return false;
            }
            else
            {
                Console.WriteLine(Constants.InvalidParameterText);
                return true;
            }
        }

        public void ChooseEquipment(Player player)
        {
            Console.WriteLine("\n" + player.Name + ", please, choose your equipment before fight");

            ConsoleKeyInfo KeyEquip;
            Console.WriteLine("To choose equipment press keys:\nh (head)\nt (torso)\na (arms)\nl (legs)\nw (weapon)" +
                "\nAfter equipment is selected, Press q to exit");

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
                                    indicator = SelectLevel("HEAD", "h", player);
                                } while (indicator);
                            }
                            break;
                        case 't': //Torso
                            {
                                do
                                {
                                    indicator = SelectLevel("TORSO", "t", player);
                                } while (indicator);
                            }
                            break;
                        case 'a': //Arms
                            {
                                do
                                {
                                    indicator = SelectLevel("ARMS", "a", player);
                                } while (indicator);
                            }
                            break;
                        case 'l': //Legs
                            {
                                do
                                {
                                    indicator = SelectLevel("LEGS", "l", player);
                                } while (indicator);
                            }
                            break;
                        case 'w': //Weapon
                            {
                                do
                                {
                                    indicator = SelectLevel("WEAPON", "w", player);
                                } while (indicator);
                            }
                            break;
                        default: break;
                    }
                }
                else { Console.WriteLine(Constants.InvalidParameterText); }
            } while (KeyEquip.KeyChar != 'q');
            Console.WriteLine("\nDefault settings have been set for unspecified values\n");
        }

        private string AttackRound()
        {
            bool isValid;
            string TargetP;
            do
            {
                TargetP = Console.ReadLine();
                TargetP = TargetP.ToLower();
                isValid = !Validation.ValidationfightRaund(TargetP);
                if (isValid) Console.WriteLine(Constants.InvalidParameterText);

            } while (isValid);
            return TargetP;
        }

        public Player Fight(Player playerOne, Player playerTwo)
        {
            int roundCounter = 1;
            do
            {
                Console.WriteLine(String.Format("ROUND {0} ========================================================================================================", roundCounter));
                string AtkTargetP1, AtkTargetP2, DefTargetP1, DefTargetP2;

                double DamageToP1, DamageToP2, DefenceRatioP1 = 1, DefenceRatioP2 = 1;

                Console.WriteLine(playerOne.Name + ", choose your attack target and defence target");
                AtkTargetP1 = AttackRound();
                DefTargetP1 = AttackRound();
                Console.WriteLine();

                Console.WriteLine(playerTwo.Name + ", choose your attack target and defence target");
                AtkTargetP2 = AttackRound();
                DefTargetP2 = AttackRound();
                Console.WriteLine();

                int DamageP1 = playerOne.GetDamageLevel(),
                    DamageP2 = playerTwo.GetDamageLevel();

                int DefenceP1 = playerOne.GetDefenceLevelFor(AtkTargetP2),
                    DefenceP2 = playerTwo.GetDefenceLevelFor(AtkTargetP1);

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

                Console.WriteLine(playerOne.Name + " dealt " + DamageToP2 + " damage to " + playerTwo.Name + ".\n" +
                    playerTwo.Name + " has " + playerTwo.HealthPoints + " health left.\n");
                Console.WriteLine(playerTwo.Name + " dealt " + DamageToP1 + " damage to " + playerOne.Name + ". \n" +
                    playerOne.Name + " has " + playerOne.HealthPoints + " health left.\n");

                roundCounter++;

            } while (playerOne.HealthPoints > 0 && playerTwo.HealthPoints > 0);

            if (playerOne.HealthPoints > 0 && playerTwo.HealthPoints <= 0)
                return playerOne;
            else if (playerTwo.HealthPoints > 0 && playerOne.HealthPoints <= 0)
                return playerTwo;
            else
                return null;
        }

        public void CongratulateWinner(Player winner)
        {
            if (winner != null)
            {
                ShowWinnerBanner();
                Console.WriteLine(winner.Name + Constants.Win);
            }
            else Console.WriteLine(Constants.Draw);
        }

        public void Countdown()
        {
            Console.WriteLine(Constants.PrepareText); Thread.Sleep(1500); //задержка 1.5 сек
            Console.WriteLine(3); Thread.Sleep(1000);
            Console.WriteLine(2); Thread.Sleep(1000);
            Console.WriteLine(1); Thread.Sleep(1000);
            Console.WriteLine("..."); Thread.Sleep(1500);
            Console.WriteLine(Constants.StartText); Thread.Sleep(1000);
        }

        private void ShowWinnerBanner()
        {
            Console.WriteLine("=============================  ___                  __        _____ _   _ _   _ _____ ____  _  ===========================");
            Console.WriteLine("============================= |_ _|  ___  ___  ___  \\ \\      / /_ _| \\ | | \\ | | ____|  _ \\| | ===========================");
            Console.WriteLine("=============================  | |  / __|/ _ \\/ _ \\  \\ \\ /\\ / / | ||  \\| |  \\| |  _| | |_) | | ===========================");
            Console.WriteLine("=============================  | |  \\__ \\  __/  __/   \\ V  V /  | || |\\  | |\\  | |___|  _ <|_| ===========================");
            Console.WriteLine("============================= |___| |___/\\___|\\___|    \\_/\\_/  |___|_| \\_|_| \\_|_____|_| \\_(_) ===========================");

        }

        private class Constants
        {
            public const string NameSelectionText = "Player {0}, enter name for your fighter!";
            public const string NameSelectedText = "AWESOME! Player {0} is created!\n";
            public const string InvalidParameterText = "\nAn invalid parameter was entered. Try again.";
            public const string Win = " IS REAL DRAGON!!!";
            public const string Draw = "BOTH OF YOU NOT WORTH OUR TIME.\n BRING THERE NEXT CHALLENGERS!!!";
            public const string PrepareText = "\nPREPARE FOR BATTLE";
            public const string StartText = "START\n";
        }
    }
}

