namespace MyFirstProgram
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string? name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek} and we're going to play a math game. Better not be stupid.\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.WriteLine(@$"Pick which game you want to play. Options are below:
        V - View Previous Games
        A - Addition (+)
        S - Subtraction (-)
        M - Multiplication (*)
        D - Division (/)
        R - Random
        Q - Quit the program");
                Console.WriteLine("_____________________________________");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "r":
                        gameEngine.RandomGame("Random game");
                        break;
                    case "q":
                        Console.WriteLine("See ya");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            } while (isGameOn);
        }
    }
}
