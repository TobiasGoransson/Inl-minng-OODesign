using Inläminng_OODesign.AddMovieFunktion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises.AddMovieChoice
{
    public class RegisterManually:IChoice
    {
        Database db;

        public RegisterManually(Database db)
        {
            this.db = db;
        }

        public void Choice()
        {
            RegisterAMovie();
        }

        public string GetDescription()
        {
            return "2. Register movie manually";
        }

        public void RegisterAMovie()
        {
            string name;
            string description;
            double duration;
            bool isNew;
            int year;
            string language;
            string contryOfOrigine;
            string productionCompany;
            int budget;

            FilmBuilder fb = new FilmBuilder();
            SettingName Sname = new SettingName(db);
            name = Sname.SettingAName();
            fb.SetName(name);

            SettingDescription SDescription = new SettingDescription();
            description = SDescription.SettingADescription();

            if (description != null)
            {
                fb.SetDescription(description);
            }

            SettingYear sYear = new SettingYear();
            year = sYear.SettingAYear();
            DateTime dateTime = DateTime.Now;
            if (year != dateTime.Year)
            {
                fb.SetNew(false);
            }
            if (year != 0)
            {
                fb.SetReleaseYear(year);
            }

            SettingDuration sDuration = new SettingDuration();
            duration = sDuration.SettingADuration();
            if (duration != 0)
            {
                fb.SetDuration(duration);
            }

            SettingLanguage sLanguage = new SettingLanguage();
            language = sLanguage.SettingALanguage();
            if (language != null)
            {
                fb.SetLanguage(language);
            }

            SettingCountryOfOrigin sCountryOfOrigin = new SettingCountryOfOrigin();
            contryOfOrigine = sCountryOfOrigin.SettingACountryOfOrigin();
            if (contryOfOrigine != null)
            {
                fb.SetCountryOfOrigin(contryOfOrigine);
            }

            SettingProductionCompany sProductionCompany = new SettingProductionCompany();
            productionCompany = sProductionCompany.SetttingAProductionCompany();
            if (productionCompany != null)
            {
                fb.SetProductionCompany(productionCompany);
            }

            SettingBudget sBudget = new SettingBudget();
            budget = sBudget.SettingABudget();
            if (budget != 0)
            {
                fb.SetBudget(budget);
            }


            Film NewMovie = fb.Build();
            db.AddMovieToDatabas(NewMovie);

        }
    }
}
