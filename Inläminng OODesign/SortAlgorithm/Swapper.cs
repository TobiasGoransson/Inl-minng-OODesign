using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.SortAlgorithm
{
    public class Swapper
    {
        public void Swap(List<FilmProxy> films, int indexA, int indexB)
        {
            FilmProxy temp = films[indexA];
            films[indexA] = films[indexB];
            films[indexB] = temp;
        }
    }
}
