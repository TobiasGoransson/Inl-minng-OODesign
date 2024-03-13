using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign
{
    public class Film
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; }
        public bool New { get; set; }
        public int Year { get; set; }
        public string Language { get; set; }
        public string CountryOfOrigin { get; set; }
        public string PruductionCompany { get; set; }
        public int Budget { get; set; }

        public Film(string name, string description, double duration, bool @new, int year, string language, string countryOfOrigin, string pruductionCompany, int budget)
        {
            Name = name;
            Description = description;
            Duration = duration;
            New = @new;
            Year = year;
            Language = language;
            CountryOfOrigin = countryOfOrigin;
            PruductionCompany = pruductionCompany;
            Budget = budget;
        }
        public void PrintFilm()
        {
            Console.WriteLine(Name + " " + Description + " " + Duration + " " + Year + " " + Language + " " + CountryOfOrigin +" " + PruductionCompany + " " + Budget);
        }

        public Film Clone()
        {
            return new Film(Name, Description, Duration, New, Year, Language, CountryOfOrigin, PruductionCompany, Budget);
        }
    }
}
