using NTierMovie.DAL.Model.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierMovie.WinForm.Tools
{
    public class ImportData
    {
        public static List<Movie> ImportMovie()
        {
            List<Movie> movieList = new List<Movie>();

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.DefaultExt = ".csv";
            ofd.Filter = "Comma Seperated (*.csv)|*.csv";
            ofd.ShowDialog();

            StreamReader reader = new StreamReader(ofd.FileName);
            string header = reader.ReadLine();

            if (string.IsNullOrEmpty(header))
            {
                MessageBox.Show("Herhangi bir data bulunamadı");
            }
            else
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fields = line.Split(',');
                    Movie movie = new Movie();
                    movie.MovieName = fields[1];
                    movieList.Add(movie);
                }
            }
            return movieList;
        }
    }
}
