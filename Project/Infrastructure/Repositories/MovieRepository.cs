using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetTop30GrossingMovies()
        {
            // SQL Database
            // data access logic
            // ADO.NET (Microsoft) SQLConnection, SQLCommand
            // Dapper (ORM) -> StackOverflow (Preferred for its lightweight and fast)
            // Entity Framework Core => LINQ
            // SELECT TOP 30 * from Movie order by Revenue
            // movies.orderbydecending(m=> m.Revenue).Take(30)
            throw new NotImplementedException();
        }
    }
}
