using ApplicationCore.Contracts.Services;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieServiceMock : IMovieService
    {
        public List<MovieCard> Get30HighestGrossingMovies()
        {
            var movies = new List<MovieCard>()
            {
                new MovieCard{ Id=11, PosterUrl="", Title="Inception" },
                new MovieCard{ Id=22, PosterUrl="", Title="" },
                new MovieCard{ Id=33, PosterUrl="", Title="" },
                new MovieCard{ Id=44, PosterUrl="", Title="" },
                new MovieCard{ Id=55, PosterUrl="", Title="" },
            };

            return movies;
        }
    }
}
