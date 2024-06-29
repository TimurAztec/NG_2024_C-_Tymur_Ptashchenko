using LinQ.Data;
using LinQ.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Game gameById = GetGameById(3);
        Console.WriteLine($"Game by ID 3: {gameById.Name}");

        IEnumerable<Game> gamesInRange = GetGamesInPriceRange(20, 50);
        Console.WriteLine("Games in price range 20 to 50:");
        foreach (var game in gamesInRange)
        {
            Console.WriteLine(game.Name);
        }

        IEnumerable<Genre> genresByGame = GetGenresByGame(1);
        Console.WriteLine("Genres for game ID 1:");
        foreach (var genre in genresByGame)
        {
            Console.WriteLine(genre.Name);
        }

        IEnumerable<string> uniqueCategories = GetUniqueCategories();
        Console.WriteLine("Unique Categories:");
        foreach (var category in uniqueCategories)
        {
            Console.WriteLine(category);
        }

        IEnumerable<Game> filteredGames = FilterGamesByCategoryAndGenres("Action", new List<string> { "Action", "RPG" });
        Console.WriteLine("Filtered Games by Category 'Action' and Genres 'Action' or 'RPG':");
        foreach (var game in filteredGames)
        {
            Console.WriteLine(game.Name);
        }

        IEnumerable<Game> pagedGames = GetGamesByPage(1);
        Console.WriteLine("Paged Games |Page 1|:");
        foreach (var game in pagedGames)
        {
            Console.WriteLine(game.Name);
        }
    }

    public static Game GetGameById(int id)
    {
        return Data.Games.FirstOrDefault(g => g.Id == id);
    }

    public static IEnumerable<Game> GetGamesInPriceRange(double minPrice, double maxPrice)
    {
        return Data.Games.Where(g => g.Price >= minPrice && g.Price <= maxPrice);
    }

    public static IEnumerable<Genre> GetGenresByGame(int gameId)
    {
        var game = GetGameById(gameId);
        return game?.Genres ?? Enumerable.Empty<Genre>();
    }

    public static IEnumerable<string> GetUniqueCategories()
    {
        return Data.Games.Select(g => g.Category).Distinct();
    }

    public static IEnumerable<Game> FilterGamesByCategoryAndGenres(string category, IEnumerable<string> genreNames)
    {
        return Data.Games.Where(g => g.Category == category && g.Genres.Any(genre => genreNames.Contains(genre.Name)));
    }

    public static IEnumerable<Game> GetGamesByPage(int pageNumber, int pageSize = 5)
    {
        return Data.Games.Skip((pageNumber - 1) * pageSize).Take(pageSize);
    }
}