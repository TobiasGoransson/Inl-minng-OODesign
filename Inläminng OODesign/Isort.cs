using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign
{
    public interface Isort
    {
        List<FilmProxy> Sort(List<FilmProxy> items );
    }
}
