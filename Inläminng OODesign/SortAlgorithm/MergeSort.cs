using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.SortAlgorithm
{
    public class MergeSort
    {
        public void Sort(List<FilmProxy> films)
        {
            if (films.Count < 2) return;

            

            int middle = films.Count / 2;
            List<FilmProxy> left = films.GetRange(0, middle);
            List<FilmProxy> right = films.GetRange(middle, films.Count - middle);

            Sort(left);
            Sort(right );

            int leftIndex = 0;
            int rightIndex = 0;
            int currentIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (string.Compare(left[leftIndex].Name, right[rightIndex].Name) < 0)
                {
                    films[currentIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    films[currentIndex] = right[rightIndex];
                    rightIndex++;
                }
                currentIndex++;
            }

            while (leftIndex < left.Count)
            {
                films[currentIndex] = left[leftIndex];
                leftIndex++;
                currentIndex++;
            }

            while (rightIndex < right.Count)
            {
                films[currentIndex] = right[rightIndex];
                rightIndex++;
                currentIndex++;
            }
        }
    }
}
