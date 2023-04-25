using System;

namespace ConstructorsYF
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("CS:GO", "M for Mature");

            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre}!");

        }
    }
}
