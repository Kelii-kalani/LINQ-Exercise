using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>() { "Grand Turismo", "Call of duty", "Twisted Metal", "Tekken tag", "NBA 2K", "Ace Combat" };

            games.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
