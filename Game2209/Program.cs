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

            Person player = new Person("Liu Kang");
            Person player2 = new Person("Sub-Zero");

            Console.WriteLine(player.ToString() + " is created!");
            Console.WriteLine(player2.ToString() + " is created!");
        }
    }
}
