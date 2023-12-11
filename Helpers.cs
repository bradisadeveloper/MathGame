using MyFirstProgram.Models;
using System.Diagnostics;
using System.Linq;

namespace MyFirstProgram
{
    internal class Helpers
    {
        internal static List<Game> games = new();
        
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("________________________________\n");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("________________________________\n");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int gameScore, GameType gameType, Level level)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType,
                Level = level,
            });
        }

        internal static void PrintGames()
        {
            var gamesToPrint = games.Where(x => x.Date > new DateTime(2022, 08, 09));

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("________________________________\n");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} - {game.Level}: {game.Score} points");
            }
            Console.WriteLine("________________________________\n");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }

        internal static int[] GetDivisionNumbers(string lvl)
        {
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);
            var result = new int[2];

            switch (lvl)
            {
                case "e":
                    firstNumber = random.Next(1, 99);
                    secondNumber = random.Next(1, 99);
                    result = new int[2];
                    while (firstNumber % secondNumber != 0)
                    {
                        firstNumber = random.Next(1, 99);
                        secondNumber = random.Next(1, 99);
                    }
                    result[0] = firstNumber;
                    result[1] = secondNumber;
                    break;
                case "m":
                    firstNumber = random.Next(1, 501);
                    secondNumber = random.Next(1, 501);

                    result = new int[2];

                    while (firstNumber % secondNumber != 0)
                    {
                        firstNumber = random.Next(1, 501);
                        secondNumber = random.Next(1, 501);
                    }

                    result[0] = firstNumber;
                    result[1] = secondNumber;
                    break;
                case "h":
                    firstNumber = random.Next(1, 1001);
                    secondNumber = random.Next(1, 1001);

                    result = new int[2];

                    while (firstNumber % secondNumber != 0)
                    {
                        firstNumber = random.Next(1, 1001);
                        secondNumber = random.Next(1, 1001);
                    }

                    result[0] = firstNumber;
                    result[1] = secondNumber;
                    break;
            }
            Console.WriteLine(result);

            return result;
        }

        internal static string? ValidateResult(string result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer, dammit! Try again!");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string? NumberOfQuestions(string numberOfQuestions)
        {
            while (string.IsNullOrEmpty(numberOfQuestions) || !Int32.TryParse(numberOfQuestions, out _))
            {
                Console.WriteLine("Your answer needs to be an integer, stupid! Try again!");
                numberOfQuestions = Console.ReadLine();
            }

            return numberOfQuestions;
        }

        internal static string? LevelChoice(string level)
        {
            while (string.IsNullOrEmpty(level) || level.Trim().ToLower() != "e" || level.Trim().ToLower() != "m" || level.Trim().ToLower() != "h")
            {
                Console.WriteLine("Choose either Easy, Medium, or Hard nimrod! Try again!");
                level = Console.ReadLine();
            }

            return level;
        }

        internal static string GetName()
        {
            Console.WriteLine("Input your name, now!");

            var name = Console.ReadLine();

            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty, idiot!");
                name = Console.ReadLine();
            }
            return name;
        }

    }
}
