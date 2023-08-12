using System;
namespace Exercise_4
{
    public class Movies
    {
        private string _title;
        private string _studio;
        private string _raiting;

        public string Title { get { return _title; } }
        public string Studio { get { return _studio; } }
        public string Rating { get { return _raiting; } }



        public Movies(string title, string studio, string raiting)
        {
            _title = title;
            _studio = studio;
            _raiting = raiting;
        }

        public Movies(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _raiting = "PG";
        }

        public static Movies[] GetPG(Movies[] movies)
        {
            int count = 0;
            foreach (var movie in movies)
            {
                if (movie._raiting == "PG")
                {
                    count++;
                }
            }
            Movies[] pgMovies = new Movies[count];

            int index = 0;
            foreach (var movie in movies)
            {
                if (movie._raiting == "PG")
                {
                     pgMovies[index] = movie;
                     index++;
                }
            }

                return pgMovies;
        }
    }
}
