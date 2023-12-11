using MyFirstProgram.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {

            Console.WriteLine("How many questions would you like to solve?");
            var numberOfQuestions = Console.ReadLine();
            numberOfQuestions = Helpers.NumberOfQuestions(numberOfQuestions);

            Console.WriteLine(@$"Pick which level you want to do. Options are below:
        E - Easy
        M - Medium
        H - Hard");
            var levelSelected = Console.ReadLine();
            //levelSelected = Helpers.LevelChoice(levelSelected);

            Console.Clear();

            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                
                if(levelSelected.Trim().ToLower() == "e")
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} + {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber + secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }
                else if (levelSelected.Trim().ToLower() == "m")
                {
                    firstNumber = random.Next(1, 100);
                    secondNumber = random.Next(1, 100);

                    Console.WriteLine($"{firstNumber} + {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber + secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }
                else if (levelSelected.Trim().ToLower() == "h")
                {
                    firstNumber = random.Next(1, 1000);
                    secondNumber = random.Next(1, 1000);

                    Console.WriteLine($"{firstNumber} + {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber + secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }
            }
            switch (levelSelected.Trim().ToLower())
            {
                case "e":
                    Helpers.AddToHistory(score, GameType.Addition, Level.Easy);
                    break;
                case "m":
                    Helpers.AddToHistory(score, GameType.Addition, Level.Medium);
                    break;
                case "h":
                    Helpers.AddToHistory(score, GameType.Addition, Level.Hard);
                    break;
            }
        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine("How many questions would you like to solve?");
            var numberOfQuestions = Console.ReadLine();
            numberOfQuestions = Helpers.NumberOfQuestions(numberOfQuestions);

            Console.WriteLine(@$"Pick which level you want to do. Options are below:
        E - Easy
        M - Medium
        H - Hard");
            string levelSelected = Console.ReadLine();
            levelSelected = Helpers.LevelChoice(levelSelected);

            Console.Clear();

            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                if (levelSelected.Trim().ToLower() == "e")
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} - {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }
                else if (levelSelected.Trim().ToLower() == "m")
                {
                    firstNumber = random.Next(1, 100);
                    secondNumber = random.Next(1, 100);

                    Console.WriteLine($"{firstNumber} - {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }
                else if (levelSelected.Trim().ToLower() == "h")
                {
                    firstNumber = random.Next(1, 1000);
                    secondNumber = random.Next(1, 1000);

                    Console.WriteLine($"{firstNumber} - {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber - secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }            
            }
            switch (levelSelected.Trim().ToLower())
            {
                case "e":
                    Helpers.AddToHistory(score, GameType.Subtraction, Level.Easy);
                    break;
                case "m":
                    Helpers.AddToHistory(score, GameType.Subtraction, Level.Medium);
                    break;
                case "h":
                    Helpers.AddToHistory(score, GameType.Subtraction, Level.Hard);
                    break;
            }

            //Helpers.AddToHistory(score, GameType.Subtraction, Level.Easy);
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine("How many questions would you like to solve?");
            var numberOfQuestions = Console.ReadLine();
            numberOfQuestions = Helpers.NumberOfQuestions(numberOfQuestions);

            Console.WriteLine(@$"Pick which level you want to do. Options are below:
        E - Easy
        M - Medium
        H - Hard");

            var levelSelected = Console.ReadLine();
            levelSelected = Helpers.LevelChoice(levelSelected);
            Console.Clear();

            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                if (levelSelected.Trim().ToLower() == "e")
                {
                    firstNumber = random.Next(1, 9);
                    secondNumber = random.Next(1, 9);

                    Console.WriteLine($"{firstNumber} x {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber * secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }
                else if (levelSelected.Trim().ToLower() == "m")
                {
                    firstNumber = random.Next(1, 25);
                    secondNumber = random.Next(1, 25);

                    Console.WriteLine($"{firstNumber} x {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber * secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }
                else if (levelSelected.Trim().ToLower() == "h")
                {
                    firstNumber = random.Next(1, 101);
                    secondNumber = random.Next(1, 101);

                    Console.WriteLine($"{firstNumber} x {secondNumber}");

                    var result = Console.ReadLine();

                    result = Helpers.ValidateResult(result);

                    if (int.Parse(result) == firstNumber * secondNumber)
                    {
                        Console.WriteLine("Correct! Type any key for the next question, genius");
                        score++;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                        Console.ReadLine();
                    }

                    if (i == int.Parse(numberOfQuestions) - 1)
                    {
                        stopwatch.Stop();
                        Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                            $"Press any key to go back to the main menu.");
                        Console.ReadLine();
                    }
                }              
            }

            switch (levelSelected.Trim().ToLower())
            {
                case "e":
                    Helpers.AddToHistory(score, GameType.Multiplication, Level.Easy);
                    break;
                case "m":
                    Helpers.AddToHistory(score, GameType.Multiplication, Level.Medium);
                    break;
                case "h":
                    Helpers.AddToHistory(score, GameType.Multiplication, Level.Hard);
                    break;
            }
        }

        internal void DivisionGame(string message)
        {
            Console.WriteLine("How many questions would you like to solve?");
            var numberOfQuestions = Console.ReadLine();
            numberOfQuestions = Helpers.NumberOfQuestions(numberOfQuestions);

            Console.WriteLine(@$"Pick which level you want to do. Options are below:
        E - Easy
        M - Medium
        H - Hard");
            var levelSelected = Console.ReadLine();
            levelSelected = Helpers.LevelChoice(levelSelected);

            Console.Clear();

            Console.WriteLine(message);

            var score = 0;

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers(levelSelected.Trim().ToLower());
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct! Type any key for the next question, genius");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                    Console.ReadLine();
                }

                if (i == int.Parse(numberOfQuestions) - 1)
                {

                    stopwatch.Stop();
                    Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                        $"Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            switch (levelSelected.Trim().ToLower())
            {
                case "e":
                    Helpers.AddToHistory(score, GameType.Division, Level.Easy);
                    break;
                case "m":
                    Helpers.AddToHistory(score, GameType.Division, Level.Medium);
                    break;
                case "h":
                    Helpers.AddToHistory(score, GameType.Division, Level.Hard);
                    break;
            }
        }

        internal void RandomGame(string message)
        {
            Console.WriteLine("How many questions would you like to solve?");
            var numberOfQuestions = Console.ReadLine();
            numberOfQuestions = Helpers.NumberOfQuestions(numberOfQuestions);

            Console.WriteLine(@$"Pick which level you want to do. Options are below:
        E - Easy
        M - Medium
        H - Hard");

            var levelSelected = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int firstNumber;
            int secondNumber;

            int addition;
            int subtraction;
            int multiplication;
            int division;

            var divisionNumbers = Helpers.GetDivisionNumbers(levelSelected.Trim().ToLower());
            var firstNumberDivide = divisionNumbers[0];
            var secondNumberDivide = divisionNumbers[1];

            for (int i = 0; i < int.Parse(numberOfQuestions); i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                int randomOperand = random.Next(1, 5);

                switch (randomOperand)
                {
                    case 1: 
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        break;
                    case 2:
                        Console.WriteLine($"{firstNumber} - {secondNumber}");
                        break;
                    case 3:
                        Console.WriteLine($"{firstNumber} * {secondNumber}");
                        break;
                    case 4:
                        Console.WriteLine($"{firstNumberDivide} / {secondNumberDivide}");
                        break;                  
                }

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                addition = firstNumber + secondNumber;
                subtraction = firstNumber - secondNumber;
                multiplication = firstNumber * secondNumber;
                division = firstNumberDivide / secondNumberDivide;

                if (int.Parse(result) == addition || int.Parse(result) == subtraction || int.Parse(result) == multiplication || int.Parse(result) == division)
                {
                    Console.WriteLine("Correct! Type any key for the next question, genius");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question, stupid!");
                    Console.ReadLine();
                }

                if (i == int.Parse(numberOfQuestions) - 1)
                {
                    stopwatch.Stop();
                    Console.WriteLine($"Game over. Your final score is {score}.\nTotal seconds of completion: {stopwatch.Elapsed.TotalSeconds:F1} seconds.\n" +
                        $"Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Random, Level.Easy);
        }
    }
}
