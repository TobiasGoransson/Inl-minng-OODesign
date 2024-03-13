using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises.AddMovieChoice
{
    public class MakeCopy : IChoice
    {
        Database db;
        public MakeCopy(Database db) 
        {
            this.db = db;
        }

        
        public void Choice()
        {
            CloneAFilm cloneAFilm = new CloneAFilm(db);
            cloneAFilm.MakeAClone();

        }

        public string GetDescription()
        {
            return "1. Make a copy";
        }

    }
}
