using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionGame
{
    class Program
    {

        //TODO Add more characters and things to do
        static void Main(string[] args)
        {
            Console.WriteLine("While adventuring in the forest, you find a witch's hut. The witch does not appear to be home, so you go inside.");
            Console.WriteLine("\"Hello,\" says a black cat. \"Would you like to play a game?\"");
            Console.WriteLine("You resist the urge to say \"I thought I was already playing one...\" and instead you say: \"Sure!\"");
            Console.WriteLine("The cat hops over to a table with three potions on it and says \"Choose one.\"");

            Red_Potion drinky = new Red_Potion();
            drinky.Affect();

            Console.ReadLine();
        }
    }
}
