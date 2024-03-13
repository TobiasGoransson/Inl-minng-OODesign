using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.SortAlgorithm
{
    public class BubbleSort
    {
        Swapper swapper = new Swapper();
        public void Sort(List<FilmProxy> films)
        {
            for (int i = films.Count - 1; i > 0; i--)
            {
                bool sorted = true;
                for (int j = 0; j < i; j++)
                {
                    if (films[j].Year.CompareTo(films[j + 1].Year) > 0)
                    {
                        swapper.Swap(films, j, j + 1);
                        sorted = false;
                    }
                }
                if (sorted)
                {
                    return;
                }
            }
        }
    }
}
