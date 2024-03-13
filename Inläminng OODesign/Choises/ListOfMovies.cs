using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises
{
    public class ListOfMovies : IChoice
    {
        Database db;
        List<FilmProxy> Movies;

        public ListOfMovies(Database db)
        {
            this.db = db;
        }

        public void Choice()
        {
            ListMovies();
        }

        public string GetDescription()
        {
            return "1. List Movies";
        }
        
        private void ListMovies()
        {
            Movies = db.GetFilmProxy();

            foreach (FilmProxy film in Movies)
            {
                Console.WriteLine(film.Name + " \t" + film.Description + " \t" + film.Year + " \t" + film.Budget);
            }
        }
    }
}
