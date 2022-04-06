using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {       
        public List<MovieCard> Get30HighestGrossingMovies()
        {
            var movies = new List<MovieCard>() 
            {
                new MovieCard{ Id=1, PosterUrl="", Title="Inception" },
                new MovieCard{ Id=2, PosterUrl="", Title="" },
                new MovieCard{ Id=3, PosterUrl="", Title="" },
                new MovieCard{ Id=4, PosterUrl="", Title="" },
                new MovieCard{ Id=5, PosterUrl="", Title="" },
            };

            return movies;
        }


    }
}
