using System;
internal class Program
{
    private static void Main(string[] args)
    {
        //int DamageP1 = player1.getDamageLevel(), DamageP2 = player2.getDamageLevel();
        do
        {
            int DamageP1 = player1.getDamageLevel(), DamageP2 = player2.getDamageLevel();
            string AtkTargetP1, AtkTargetP2, DefTargetP1, DefTargetP2;
            double DamageToP1, DamageToP2, DefenceRatioP1 = 1, DefenceRatioP2 = 1;
            Console.WriteLine("P1 chose attack target / P1 defence target");
            AtkTargetP1 = Console.ReadLine();   AtkTargetP1 = AtkTargetP1.ToLower();
            DefTargetP1 = Console.ReadLine();   DefTargetP1 = DefTargetP1.ToLower();
            Console.WriteLine("P2 chose attack target / P2 defence target");
            AtkTargetP2 = Console.ReadLine();   AtkTargetP2 = AtkTargetP2.ToLower();
            DefTargetP2 = Console.ReadLine();   DefTargetP2 = DefTargetP2.ToLower();
            int DefenceP1 = player1.getDefenceLevelFor(AtkTargetP2),
                DefenceP2 = player2.getDefenceLevelFor(AtkTargetP1);
            if (DefTargetP2 == AtkTargetP2)
            {
                DefenceRatioP1 = 0.75;
            }
            if (DefTargetP2 == AtkTargetP1)
            {
                DefenceRatioP2 = 0.75;
            }
            DamageToP1 = Math.Ceiling((DamageP2 - DefenceP1) * DefenceRatioP1);
            DamageToP2 = Math.Ceiling((DamageP1 - DefenceP2) * DefenceRatioP2);
            player1.reduceHealthPoints(DamageToP1);
            player2.reduceHealthPoints(DamageToP2);
        } while (player1.healthPoints >= 0 || player2.healthPoints >= 0);
    }
}