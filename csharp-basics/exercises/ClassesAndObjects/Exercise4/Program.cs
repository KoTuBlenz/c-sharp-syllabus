using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> moviesList = new List<Movie>
            {
                new Movie("Casino Royale","Eon Productions","PG­13"),
                new Movie("Glass", "Buena Vista International", "PG­13"),
                new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures")
            };
            List<Movie> moviesPg = Movie.GetPG(moviesList);
            foreach (Movie movie in moviesPg)
            {
                movie.printMovie();
            }
            Console.ReadKey();
        }
    }
    class Movie
    {
        private string _movieTitle;
        private string _movieStudio;
        private string _movieRating;
        //Movie contructor which takes 3 arguments: movie tile, studio and rating
        public Movie(string movieTitle, string movieStudio, string movieRating)
        {
            _movieTitle = movieTitle;
            _movieStudio = movieStudio;
            _movieRating = movieRating;
        }
        //Movie contructor which takes 2 arguments: movie tile and studio
        //Sets rating to PG
        public Movie(string movieTitle, string movieStudio)
        {
            _movieTitle = movieTitle;
            _movieStudio = movieStudio;
            _movieRating = "PG";
        }
        //Displays information about movie
        public void printMovie()
        {
            Console.WriteLine($"\"{_movieTitle}\" made by \"{_movieStudio}\", rated ({_movieRating})");
        }
        //Checks if movie is rated PG
        private bool isMoviePG()
        {
            return _movieRating == "PG";
        }
        //Takes a list of movies as an argument and displays list of movies rated PG
        public static List<Movie> GetPG(IList<Movie> movies)
        {
            List<Movie> moviesPG = new List<Movie> { };
            foreach (Movie movie in movies)
            {
                if (movie.isMoviePG()) moviesPG.Add(movie);
            }
            return moviesPG;
        }
    }
}
