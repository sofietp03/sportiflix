

namespace sportiflix
{
    internal class Music : Parent
    {
        public string? Artist { get; set; }
        public string? Album { get; set; }
        public MusicGenre Genre { get; set; }
    }
    enum MusicGenre { Rock=1, Pop }
}
