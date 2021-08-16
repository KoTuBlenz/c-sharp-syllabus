using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Program
    {
        private const int _countOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();
        private static void Main(string[] args)
        {
            //Adding a list of movies to test code
            _videoStore.AddVideo("The Matrix");
            _videoStore.TakeUsersRating(8, "The Matrix");
            _videoStore.AddVideo("Godfather II");
            _videoStore.TakeUsersRating(7, "Godfather II");
            _videoStore.AddVideo("Star Wars Episode IV: A New Hope");
            _videoStore.TakeUsersRating(6, "Star Wars Episode IV: A New Hope");

            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to rate a video (as user)");
                Console.WriteLine("Choose 5 to list inventory");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        RateVideo();
                        break;
                    case 5:
                        ListInventory();
                        break;
                    default:
                        return;
                }
                Console.Clear();
            }
        }

        private static void ListInventory()
        {
            _videoStore.ListInventory();
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
        }

        private static void RateVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();

            Console.WriteLine("Enter rating");
            int rating = Convert.ToInt16(Console.ReadLine());

            _videoStore.TakeUsersRating(rating, movieName);
        }
        private static void FillVideoStore()
        {
            for (var i = 0; i < _countOfMovies; i++)
            {
                Console.WriteLine("Enter movie name");
                string movieName = Console.ReadLine();

                Console.WriteLine("Enter rating");
                int rating = Convert.ToInt16(Console.ReadLine());

                _videoStore.AddVideo(movieName);
                _videoStore.TakeUsersRating(rating, movieName);
            }
        }

        private static void RentVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            _videoStore.Checkout(movieName);
        }

        private static void ReturnVideo()
        {
            Console.WriteLine("Enter movie name");
            string movieName = Console.ReadLine();
            _videoStore.ReturnVideo(movieName);
        }
    }
}
