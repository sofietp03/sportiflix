

namespace sportiflix
{
    internal abstract class Parent
    {
        public string? Title { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public int lengthInSeconds { get; set; }
        
        public string? WWW { get; set; }
    }

    enum Genre
    {
        Horror =1, Comedy, Action, SciFi
    }
}

    