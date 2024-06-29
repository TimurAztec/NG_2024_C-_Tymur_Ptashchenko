using LinQ.Models;

namespace LinQ.Data
{
    public class Data
    {
        public static List<Genre> Genres = new List<Genre>
        {
            new Genre { Name = "Action", Description = "Action games" },
            new Genre { Name = "Adventure", Description = "Adventure games" },
            new Genre { Name = "Strategy", Description = "Strategy games" },
            new Genre { Name = "RPG", Description = "Role-playing games" },
            new Genre { Name = "Simulation", Description = "Simulation games" }
        };

        public static List<Game> Games = new List<Game>
        {
            new Game { Id = 1, Name = "Dragon Slayer", Price = 29.99, Category = "Action", Genres = new List<Genre> { Genres[0], Genres[1] } },
            new Game { Id = 2, Name = "Mystic Quest", Price = 39.99, Category = "Adventure", Genres = new List<Genre> { Genres[1] } },
            new Game { Id = 3, Name = "Empire Builder", Price = 19.99, Category = "Strategy", Genres = new List<Genre> { Genres[2] } },
            new Game { Id = 4, Name = "Hero's Journey", Price = 49.99, Category = "RPG", Genres = new List<Genre> { Genres[3] } },
            new Game { Id = 5, Name = "Farm Simulator", Price = 24.99, Category = "Simulation", Genres = new List<Genre> { Genres[4] } },
            new Game { Id = 6, Name = "Warrior's Path", Price = 59.99, Category = "Action", Genres = new List<Genre> { Genres[0], Genres[3] } },
            new Game { Id = 7, Name = "Treasure Hunter", Price = 34.99, Category = "Adventure", Genres = new List<Genre> { Genres[1], Genres[2] } },
            new Game { Id = 8, Name = "City Planner", Price = 44.99, Category = "Strategy", Genres = new List<Genre> { Genres[2], Genres[4] } },
            new Game { Id = 9, Name = "Dungeon Explorer", Price = 54.99, Category = "RPG", Genres = new List<Genre> { Genres[3], Genres[0] } },
            new Game { Id = 10, Name = "Life Simulator", Price = 14.99, Category = "Simulation", Genres = new List<Genre> { Genres[4], Genres[1] } }
        };

    }
}
