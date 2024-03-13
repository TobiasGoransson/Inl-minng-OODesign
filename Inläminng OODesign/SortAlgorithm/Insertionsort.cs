using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.SortAlgorithm
{
    public class InsertionSort
    {
        public void Sort(List<FilmProxy> films)
        {
            for (int i = 1; i < films.Count; i++)
            {
                FilmProxy valueToSort = films[i];
                int j = i;

                while (j > 0 && valueToSort.Budget < films[j - 1].Budget)
                {
                    films[j] = films[j - 1];
                    j--;
                }

                films[j] = valueToSort;
            }
        }
    }
}
