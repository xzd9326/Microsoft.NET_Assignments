using ApplicationCore.Models;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieTestService
    {
        public List<MovieCardModel> GetTop30GrossingMovies()
        {
            // call the movierepository class
            // get the entity class data and map them in to model class data
            var movieRepo = new MovieRepository();
            var movies = movieRepo.GetTop30GrossingMovies().Take(6);

            var movieCards = new List<MovieCardModel>();

            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardModel
                {
                    Id = movie.Id,
                    PosterUrl = movie.PosterUrl,
                    Title = movie.Title
                });
            }

            return movieCards;
        }
    }
}
