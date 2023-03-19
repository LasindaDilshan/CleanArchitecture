using CleanMovie.Application;
using CleanMovieDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        public static List<Movie> movies = new List<Movie>()
        {
            new Movie{ Id = 1 , Name = "Lord Of The rings" , Cost = 2} ,
             new Movie{ Id = 1 , Name = "Magic Elephent" , Cost = 1}
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
