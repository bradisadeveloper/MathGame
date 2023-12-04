using MyFirstProgram;

var menu = new Menu();

var date = DateTime.UtcNow;

List<string> games = new();

string name = Helpers.GetName();

menu.ShowMenu(name, date);

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: Score={gameScore}");
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    Console.WriteLine(result);

    return result;
}


