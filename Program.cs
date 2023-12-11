using MyFirstProgram;

var menu = new Menu();

var date = DateTime.UtcNow;

List<string> games = new();

string name = Helpers.GetName();

menu.ShowMenu(name, date);

void AddToHistory(int gameScore, string gameType, string level)
{
    games.Add($"{DateTime.Now} - {gameType} - {level}: Score={gameScore}");
}

//static int[] GetDivisionNumbers(string lvl)
//{
//    var random = new Random();
//    var firstNumber = random.Next(1, 101);
//    var secondNumber = random.Next(1, 101);

//    var result = new int[2];

//    while (firstNumber % secondNumber != 0)
//    {
//        firstNumber = random.Next(1, 101);
//        secondNumber = random.Next(1, 101);
//    }

//    result[0] = firstNumber;
//    result[1] = secondNumber;

//    Console.WriteLine(result);

//    return result;
//}


