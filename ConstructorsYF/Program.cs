using System;

namespace ConstructorsYF
{
    class Program
    {
        /// <summary>
        /// The Program class holds the main method and initializes the values of a favorite game
        /// the title and genre of the Game object is printed to the console
        /// another Game object is made without any initialized values
        /// the title and genre of the other Game object to the console
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            Game myGame = new Game("CS:GO", "FPS");

            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            Game myOtherGame = new Game();

            Console.WriteLine($"My favorite game is {myOtherGame.title} and it is rated {myOtherGame.genre}!");
        }
    }
}
