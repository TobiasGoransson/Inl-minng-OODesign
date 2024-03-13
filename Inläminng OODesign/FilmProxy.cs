using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign
{
    public class FilmProxy
    {
        private Film Movie;
        private Database db;
        public string Name;
        public int Year;
        public string Description;
        public int Budget;

        public FilmProxy(Database db, string name, string description, int year, int budget)
        {
            this.db = db;
            this.Name = name;
            this.Year = year;
            this.Description = description;
            this.Budget = budget;

        }

        public double Duration
        {
            get
            {
                Load() ; 
                return Movie.Duration;
            }
            set
            {
                Load();
                Movie.Duration = value;
            }
        }

        public bool New
        {
            get
            {
                Load () ;
                return Movie.New;
            }
            set
            {
                Load ();
                Movie.New = value;
            }
        } 
        public string Language
        {
            get
            {
                Load();
                return Movie.Language;
            }
            set
            {
                Load();
                Movie.Language = value;
            }
        }
        public string CountryOfOrigin
        {
            get
            {
                Load();
                return Movie.CountryOfOrigin;
            }
            set
            {
                Load();
                Movie.CountryOfOrigin = value;
            }
        }
        public string ProductionCompany
        {
            get
            {
                Load();
                return Movie.PruductionCompany;
            }
            set
            {
                Load();
                Movie.PruductionCompany = value;    
            }
        }

        public void Load() 
        {
            if (Movie == null)
            {
                Console.WriteLine($"Loading {Movie.Name} ");
                Movie = db.GetFilm(Name);
            }
        }

    }
}
