using Inläminng_OODesign.SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises.SortChoise
{
    public class SortByYear : IChoice
    {
        Database db;

        List<FilmProxy> Movies;

        public SortByYear(Database db)
        {
            this.db = db;
            Movies = db.GetFilmProxy();
        }

        public void Choice()
        {
            SortingByYear();
        }

        public string GetDescription()
        {
            return "3. Sort by yesr";
        }

        private void SortingByYear()
        {
            Console.WriteLine();
            BubbleSort bubblesort = new BubbleSort();
            bubblesort.Sort(Movies);
            foreach (FilmProxy film in Movies)
            {
                Console.WriteLine(film.Year + " \t" + film.Name + " \t" + film.Description + " \t" + film.Budget);
            }
            Console.WriteLine();
        }
    }
}
