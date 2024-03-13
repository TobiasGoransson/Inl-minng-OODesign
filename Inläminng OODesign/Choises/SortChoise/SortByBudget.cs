using Inläminng_OODesign.SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises.SortChoise
{
    public class SortByBudget : IChoice
    {
        Database db ;

        List<FilmProxy> Movies;

        public SortByBudget(Database db)
        {
            this.db = db;
            Movies = db.GetFilmProxy();
        }

        public void Choice()
        {
            SortingByBudget();
        }

        public string GetDescription()
        {
            return "4. Sort by Budget";
        }
        private void SortingByBudget()
        {
            Console.WriteLine();
            InsertionSort insertionsort = new InsertionSort();
            insertionsort.Sort(Movies);
            foreach (FilmProxy film in Movies)
            {
                Console.WriteLine(film.Budget + " \t" + film.Name + " \t" + film.Description + " \t" + film.Year);
            }
            Console.WriteLine();

        }
    }
}
