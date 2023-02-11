using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine("First off choose your helmet");
            Console.WriteLine("Now its time for chestplate");
            Console.WriteLine("Greave are important too");
            Console.WriteLine("Dont forget vambraces!!!");

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
