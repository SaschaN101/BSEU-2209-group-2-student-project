using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2209
{
    internal class Constants
    {
        public static string Greetings = "Hello. Are you ready?";  //приветствие
        public static string PossibleChoice = "Available input Y if yes, N if no"; // варианты ввода Y-если да,  N - если нет 
        public static string NotValid = "Incorrect choice. Try again";    // неправильный выбор, попробуйте снова
        public static string PlayerProfile1 = "Сustomize the player 1";   //Настройте игрока 1
        public static string PlayerProfile2 = "Сustomize the player 2";   //Настройте игрока 2
        public static string StartGame = "Start of the round";           //начать раунд
        public static string Protection = "Choose protection";          // защита
        public static string Weapon = "Select weapon";
        public static string Attack = "Choose the location of the attack";
        public static string Defense = "Сhoose a place of protection";
        public static string Damage = "Damage done";
        public static string Health = "Health left";
        public static string Win = "Great win";
        public static string Draw = "Just a draw";
        public static string Rematch = "Rematch";
        public static string Exit = "Exit from the game";


        public static string player(string name)
        {
            return "Player " + name + " is ready";
        }

    }

}
