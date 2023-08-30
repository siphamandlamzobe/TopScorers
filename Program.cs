using TopScrores;
using TopScrores.Model;

namespace TopScorers;

public class Program
{
    public static void Main(string[] args)
    {
        ICSVReader csvReader = new CSVReader();

        var fileName = "TestData.csv";

        var players = csvReader.ReadCSV(fileName);

        var highestScore = GetHighestScore(players);

        var topPlayers = GetTopScorers(players, highestScore);

        foreach( var player in topPlayers) 
        {
            Console.WriteLine($"{player}");
        }


        Console.WriteLine($"Score: {highestScore}");
    }

    public static int GetHighestScore(List<Player> players)
    {
        return players.Max(p => p.Score);
    }

    public static List<string> GetTopScorers(List<Player> players, int highestScore)
    {
        var topScorers = players.Where(o => o.Score == highestScore).Select(o => o.Name + ' ' + o.Surname).OrderBy(name => name).ToList();

        return topScorers;
    }
}