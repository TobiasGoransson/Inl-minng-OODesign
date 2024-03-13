using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign
{
    public class CloneAFilm
    {
        Database db;
        

        public CloneAFilm(Database db)
        {
            this.db = db;
           
        }
        public void MakeAClone()
        {
            Console.WriteLine("Wich movie do you whant to Clone");
            string name = Console.ReadLine();   
            Film chosenFilm = db.GetFilm(name);

            CloneMovie(chosenFilm);
        }

        public void CloneMovie(Film film)
        {
            Film NewMovie = film.Clone();
            Console.WriteLine("What is the name of the new movie");
            string name = Console.ReadLine();

            NewMovie.Name = name;

            db.AddMovieToDatabas(NewMovie);

        }
    }
}
