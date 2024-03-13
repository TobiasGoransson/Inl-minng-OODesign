using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.SortAlgorithm
{
    public class Quicksort
    {


        Swapper swapper = new Swapper();

        public void Sort(List<FilmProxy> films)
        {
            Sort(films, 0, films.Count - 1);
        }

        private void Sort(List<FilmProxy> films, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(films, start, end);
                Sort(films, start, pivotIndex - 1);
                Sort(films, pivotIndex + 1, end);
            }
        }

        private int Partition(List<FilmProxy> films, int start, int end)
        {
            FilmProxy pivot = films[end];
            int pivotIndex = start;
            for (int i = start; i < end; i++)
            {
                if (films[i].Description.CompareTo(pivot.Description) < 0)
                {
                    swapper.Swap(films, i, pivotIndex);
                    pivotIndex++;
                }
            }
            swapper.Swap(films, pivotIndex, end);
            return pivotIndex;
        }
    }
}
