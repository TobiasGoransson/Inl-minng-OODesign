using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inläminng_OODesign.AddMovieFunktion
{
    public class SettingName
    {
        Database db;
        List<FilmProxy> Movies;
        string name;
        public SettingName(Database db) 
        {
            this.db = db;
            Movies = db.GetFilmProxy();
        }

        public string SettingAName() 
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("What is the movies name");
                name = Console.ReadLine();

                foreach (var movie in Movies)
                {
                    if (movie.Name == name)
                    {
                        Console.WriteLine(name + " alraedy exists");
                    }
                    else if (name == "")
                    {
                        Console.WriteLine("The Movie needs to have a name");
                    }
                    else
                    {
                        loop = false;
                    }
                   
                }
            }
            return name;
        }
    }
}
