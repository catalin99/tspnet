using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    public partial class Movie
    {
        public bool DeleteMovie(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var movie = ctx.Movies.FirstOrDefault(u => u.ID == id);
                if (movie != default(Movie))
                {
                    movie.FlgMoved = true;
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public Movie GetMovieById(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var movie = ctx.Movies.FirstOrDefault(m => m.ID == id);
                if (movie != default(Movie))
                    return movie;
                return null;
            }
        }

        public List<Movie> GetAllMovies()
        {
            using (Model1Container ctx = new Model1Container())
            {
                return ctx.Movies.Where(m => m.FlgMoved == false).ToList();
            }
        }

        public Movie UpdateMovie(int id,string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int duration)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var movie = ctx.Movies.FirstOrDefault(m => m.ID == id);
                movie.FullPath = fullPath;
                movie.MovieName = movieName;
                movie.CreationDate = creationDate;
                movie.Event = corelatedEvent;
                movie.TaggedPersons = taggedPersons;
                movie.Location = location;
                movie.Duration = duration;
                ctx.SaveChanges();
                return movie;
            }
        }

        public Movie CreateMovie(string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int duration)
        {
            using (Model1Container ctx = new Model1Container())
            {
                Movie movie = new Movie()
                {
                    ID = new Random().Next(1,10000),
                    FullPath = fullPath,
                    MovieName = movieName,
                    CreationDate = creationDate,
                    Event = corelatedEvent,
                    TaggedPersons = taggedPersons,
                    Location = location,
                    Duration = duration
                };
                ctx.Movies.Add(movie);
                ctx.SaveChanges();
                return movie;
            }
        }
    }
}
