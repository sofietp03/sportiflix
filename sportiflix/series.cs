
namespace sportiflix
{
    internal class Series : Parent
    {
        public Genre Genre { get; set; }
        public string? EpisodeName { get; set; }
        public int Season { get; set; }

        public int Episode { get; set; }

    }
}
