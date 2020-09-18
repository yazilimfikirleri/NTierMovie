using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierMovie.DAL.Context;
using NTierMovie.DAL.Model.Entity;

namespace NTierMovie.BLL.Service
{
    public class MovieService
    {
        MovieContext context = new MovieContext();


        //Get Movies
        public List<Movie> GetMovies()
        {
           return context.Movies.ToList();
        }

        //SelectById

        //AddMovie

        //UpdateMovie

        //GetRandomMovie

        //GetTopRankMovie




    }
}
