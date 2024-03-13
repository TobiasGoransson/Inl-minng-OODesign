using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign
{
    public class FilmBuilder
    {
        private string Name { get; set; } = string.Empty;
        private string Description { get; set; } = string.Empty;
        private double Duration { get; set; } = 0;
        private bool New { get; set; } = true;
        private int Year { get; set; } = 2024;
        private string Language { get; set; } = string.Empty;
        private string CountryOfOrigin { get; set; } = String.Empty;
        private string ProductionCompany { get; set; } = string.Empty;
        private int Budget { get; set; } = 0;

        public FilmBuilder SetName(string name) {  this.Name = name; return this; }
        public FilmBuilder SetDescription(string description) {  this.Description = description; return this; }
        public FilmBuilder SetDuration(double duration) { this.Duration = duration; return this; }
        public FilmBuilder SetNew(bool New) { this.New = New; return this; }
        public FilmBuilder SetReleaseYear(int Year) { this.Year = Year; return this; }
        public FilmBuilder SetLanguage(string Language) { this.Language = Language; return this; }
        public FilmBuilder SetCountryOfOrigin(string CountryOfOrigin) {  this.CountryOfOrigin = CountryOfOrigin; return this; }
        public FilmBuilder SetProductionCompany(string ProductionCompany) { this.ProductionCompany = ProductionCompany; return this; }
        public FilmBuilder SetBudget(int Budget) {  this.Budget = Budget; return this; }

        public Film Build()
        {
            return new Film (Name, Description, Duration, New, Year, Language, CountryOfOrigin, ProductionCompany, Budget);

        }

    }
}
 