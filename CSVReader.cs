using TopScrores.Model;

namespace TopScrores;

public class CSVReader : ICSVReader
{
    List<Player> playerList = new List<Player>();
    public List<Player> ReadCSV(string filename)
    {
        var fileLines = File.ReadAllLines(filename);

        for(int i = 1; i < fileLines.Length; i++)
        {
            var fileContent = fileLines[i].Split(',');

            var player = new Player()
            {
                Name = fileContent[0], 
                Surname = fileContent[1],
                Score = int.TryParse(fileContent[2], out var score) ? score : 0,
            };

            playerList.Add(player);

        }

        return playerList;
    }
}
