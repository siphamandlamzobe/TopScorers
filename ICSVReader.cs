using TopScrores.Model;

namespace TopScrores;

public interface ICSVReader
{
    List<Player> ReadCSV(string filename);
}
