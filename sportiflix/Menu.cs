
namespace sportiflix
{
    internal class Menu : Parent
    {
        Data? data = new Data();
        //tjek om fil eksitere hvis den gør skal den loads ellers skal man oprette en ny entans af data og lister
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Sportiflix.json";

        public Menu()
        {
          
            if (File.Exists(path))
            {
                data = new Filhandling().LoadData<Data>(path);
            }
            else
            {
                data.MusicList = new List<Music>();
                data.SerieList = new List<Series>();
                data.MovieList = new List<Movie>();
                new Filhandling().SaveData(path,data);
            }
        }
        
        public void Start()
        {
            data.MovieList = new List<Movie>();
            data.SerieList = new List<Series>();
            data.MusicList = new List<Music>();


            while (true)
            {
                
                Console.WriteLine("welcome to your media collection :)");
                Console.WriteLine("press 1 for add new");
                Console.WriteLine("press 2 for search");
                Console.WriteLine("press 3 for view all");
             
                switch (Console.ReadKey(true).Key)
                {



                    case ConsoleKey.D1:
                        AddNew();

                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        ViewAll();
                        break;
                }


            }

        }
        public void AddNew()
        {
            Console.Clear();
            Console.WriteLine("what type do you want add til \n 1:film\n2:serie\n 3:songs");
            Console.WriteLine("press 9 for going back to the last menu");



            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    AddMovie();                 
                    break;
                    case ConsoleKey.D2:
                    AddSerie();
                    break;
                case ConsoleKey.D3:
                    AddSong();
                    break;
                case ConsoleKey.D9:
                    return;
                default:

                    
                    break;
                    

            }

        }
       
        public void AddMovie()
        {
            Console.Clear();
            Console.WriteLine("what is the titel of the movie ");
            string? title = Console.ReadLine();
            Console.WriteLine("write the length on the movie in (hh:mm)");
            string[]? me = Console.ReadLine().Split(":");
            int total = Timeconverter.HourToMinutes(int.Parse (me[0]), int.Parse(me[1]));
            Console.WriteLine("what genre is it \n 1: Horror \n 2: comedy");
            int Moviegenre = int.Parse (Console.ReadLine());  
            Console.WriteLine("where do you see it");
            string? www = Console.ReadLine();
            Console.WriteLine("what did the movie come out (yyyy-mm-dd)");
            DateTime release = DateTime.Parse (Console.ReadLine());
            


            Movie movie = new Movie() { Title = title, lengthInSeconds = total, WWW = www, Genre = (Genre)Moviegenre,ReleaseDate = release};
            data.MovieList.Add(movie);
             new Filhandling ().SaveData(path,data);

        }

        public void AddSerie()
        {
            Console.Clear();
            Console.WriteLine("what is the titel of the serie");
            string? title = Console.ReadLine ();
            Console.WriteLine("what is the titel of the episode");
            string? episodename = Console.ReadLine ();
            Console.WriteLine("what  episodes is it");
            int episode = int.Parse(Console.ReadLine());
            Console.WriteLine("how many season are there in the serie");
            int season = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the genre of the serie\n1:Horre\n2:comedy\n3:Action\n4:Scifi");
            int seriegenre = int.Parse(Console.ReadLine());
            Console.WriteLine("write the length on the episode in (mm:ss)");
            string[]? ep = Console.ReadLine().Split(":");
            int total = Timeconverter.MinutesAndSecounds (int.Parse(ep[0]), int.Parse(ep[1]));
            Console.WriteLine("where do you see it");
            string? www = Console.ReadLine();
            Console.WriteLine("when did the serie come out (yyyy-mm-dd)");
            DateTime release = DateTime.Parse(Console.ReadLine());
       

            Series series = new Series(){Title = title,EpisodeName = episodename,Episode= episode,Season = season,
             Genre = (Genre)seriegenre, lengthInSeconds = total, ReleaseDate = release,WWW = www};
             data.SerieList.Add(series);
             new Filhandling().SaveData(path,data);
        }

        
       public void AddSong()
        {
           Console.Clear ();
            Console.WriteLine("what is the title of the song");
            string? title = Console.ReadLine();
            Console.WriteLine("what is tthe name of the artist");
            string? artist = Console.ReadLine();
            Console.WriteLine("what is the genre of the song\n 1:rock\n2:pop");
            int musicgenre = int.Parse(Console.ReadLine());
            Console.WriteLine("what album is the song in");
            string? album = Console.ReadLine();
            Console.WriteLine("write the length on the song in (mm:ss)");
            string[]? s = Console.ReadLine().Split(":");
            int total = Timeconverter.MinutesAndSecounds(int.Parse(s[0]), int.Parse(s[1]));
            Console.WriteLine("when did the song come out (yyyy-mm-dd)");
            DateTime release = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("where do you hear the song");
            string? www = Console.ReadLine();


            Music music = new Music() {Title = title,Artist=artist,Genre =(MusicGenre)musicgenre,Album = album,lengthInSeconds = total,ReleaseDate=release,WWW=www};
            data.MusicList.Add(music);
           new Filhandling().SaveData(path,data);
        }




        public void ViewAll()
        {
            foreach (Movie movie in data.MovieList)
            {
                Console.WriteLine($"title: {movie.Title}\n length: {movie.lengthInSeconds}\n website: {movie.WWW}\n genre: {movie.Genre}\n releasedate: {movie.ReleaseDate}");
            }


            foreach(Series series in data.SerieList)
            {
                Console.WriteLine($"title: {series.Title}\n episode title: {series.EpisodeName}\n what episode: {series.Episode}\n how many seasons: {series.Season}\n genre: {series.Genre}\n length " +
                    $"{series.lengthInSeconds}\n release: {series.ReleaseDate}\n website: {series.WWW}");
            }

            foreach(Music music in data.MusicList)
            {
                Console.WriteLine($"title: {music.Title}\n artist: {music.Artist}\n genre:{music.Genre}\n album: {music.Album}\n length: {music.lengthInSeconds}\n release ");
            }
        }
    }
}
