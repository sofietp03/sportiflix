

namespace sportiflix
{
    internal class Music
    {

        void Start()
        {
            Console.WriteLine("welcome to your media collection :)");
            Console.WriteLine("press 1 for add new");
            Console.WriteLine("press 2 for search");
            Console.WriteLine("press 3 for view all");


            switch (Console.ReadKey(true).Key)
            {



                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                default:
                    break;
            }


        }
    }
}
