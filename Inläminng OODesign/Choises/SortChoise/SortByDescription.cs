using Inläminng_OODesign.SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises.SortChoise
{
    public class SortByDescription : IChoice
    {
        Database db;

        List<FilmProxy> Movies;

        public SortByDescription(Database db)
        {
            this.db = db;
            Movies = db.GetFilmProxy();
        }

        public void Choice()
        {
            SortingByDescription();
        }

        public string GetDescription()
        {
            return "2. Sort by Description";
        }

        private void SortingByDescription()
        {
            Console.WriteLine();
            Quicksort quicksort = new Quicksort();
            quicksort.Sort(Movies);
            foreach (FilmProxy film in Movies)
            {
                Console.WriteLine(film.Description + " \t" + film.Name + " \t" + film.Year + " \t" + film.Budget);
            }
            Console.WriteLine();
        }
    }
}
