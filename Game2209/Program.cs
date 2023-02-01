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

    class Person
    {
        public void init(string name)
        {
            Console.WriteLine(Constants.player(name));
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

            Person player = new Person();
            Person player2 = new Person();

            player.init("1");
            player2.init("2");
        }
    }
}
