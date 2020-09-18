using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NTierMovie.DAL.Model.Entity;

namespace NTierMovie.DAL.Context
{
    public class MovieContext:DbContext
    {
        public MovieContext()
        {
            //todo: connection string appconfig dosyasına taşınacak.
            Database.Connection.ConnectionString = "server=.;database=MovieDB;uid=sa;pwd=123;";
        }

        public DbSet<Movie> Movies { get; set; }

    }
}
