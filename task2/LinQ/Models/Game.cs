
namespace LinQ.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
