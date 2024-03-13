using Inläminng_OODesign.SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises.SortChoise
{
    public class SortByName : IChoice
    {
        Database db;

        List<FilmProxy> Movies;

        public SortByName(Database db)
        {
            this.db = db;
            
        }

        public void Choice()
        {
           SortingByName();
        }

        public string GetDescription()
        {
            return "1. Sort by Name";
        }

        private void SortingByName()
        {
            Movies = db.GetFilmProxy();
            Console.WriteLine();
            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort(Movies);
            foreach (FilmProxy film in Movies)
            {
                Console.WriteLine(film.Name + " \t" + film.Description + " \t" + film.Year + " \t" + film.Budget);
            }
            Console.WriteLine();
        }
    }
}
