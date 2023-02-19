
namespace Game2209
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.ShowHelloBanner();

            Player playerOne = game.CreatePlayer(1);
            Player playerTwo = game.CreatePlayer(2);

            game.ChooseEquipment(playerOne);
            game.ChooseEquipment(playerTwo);

            Player winner = game.Fight(playerOne, playerTwo);
            game.Countdown();

            game.CongratulateWinner(winner);
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

            Constants.Countdown(); // обратный отсчёт

            do
            {
                string AtkTargetP1, AtkTargetP2, DefTargetP1, DefTargetP2;
                
                double DamageToP1, DamageToP2, DefenceRatioP1 = 1, DefenceRatioP2 = 1;
                    
                Console.WriteLine(player1.ToString() + " choose your attack target and defence target");
                    AtkTargetP1 = Console.ReadLine(); AtkTargetP1 = AtkTargetP1.ToLower();
                    DefTargetP1 = Console.ReadLine(); DefTargetP1 = DefTargetP1.ToLower();
                Console.WriteLine();
                
                Console.WriteLine(player2.ToString() + " choose your attack target and defence target");
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
