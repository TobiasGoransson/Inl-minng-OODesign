using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign
{
    public class Database
    {
        List<Film> films = new List<Film>();
        public Database() 
        {
            Film film1 = new Film("Nyckeln till frihet", "Drama", 2.22, false, 1994 , "English", "US", "Castle Rock Entertainment", 25000000);
            Film film2 = new Film("Gudfadern", "Drama", 2.55, false, 1972 , "English", "US", "Paramount Pictures", 6000000);
            Film film3 = new Film("The Dark Knight", "Action", 2.32, false, 2008 , "English", "US", "Warner Bros", 185000000);
            Film film4 = new Film("Gudfadern II", "Drama", 3.22, false, 1974 , "English", "US", "Paramount Pictures", 13000000);
            Film film5 = new Film("Schindlers list", "Drama", 3.15, false, 1993 , "English", "US", "Universal Pictures", 22000000);
            Film film6 = new Film("12 Edsvurna män", "Drama", 1.36, false, 1957 , "English", "US", "Orion-Nova Productions", 350000);
            Film film7 = new Film("Sagan om Konungens återkomst", "Fantasy", 3.21, false, 1993 , "English", "New Zealand", "New Line Cinema", 94000000);
            Film film8 = new Film("Pulp Fiction", "Drama", 2.34, false, 1994 , "English", "US", "Miramax", 8000000);
            Film film9 = new Film("Sagan om ringen", "Fantasy", 2.58, false, 2001 , "English", "New Zealand", "New Line Cinema", 93000000);
            Film film10 = new Film("Dune Part two", "Adventure", 2.46, true, 2024 , "English", "Canada", "Legendary Entertainment", 190000000);
            Film film11 = new Film("Den onde dengode den Fule", "Adventure", 2.41, false, 1966 , "English", "US", "Produzioni Europee Associate (PEA)", 1200000);
            Film film12 = new Film("Forest Gump", "Drama", 2.22, false, 1994 , "English", "US", "Paramount Pictures", 55000000);
            Film film13 = new Film("Sagan om de två tornen", "Fantasy", 2.59, false, 2002 , "English", "US", "New Line Cinema", 94000000);
            Film film14 = new Film("Gökboet", "Drama", 2.13, false, 1975 , "English", "US", "Fantasy Films", 3000000);
            Film film15 = new Film("Fight Club", "Action", 2.19, false, 1999 , "English", "US", "Fox 2000 Pictures", 63000000);
            Film film16 = new Film("Inseption", "Action", 2.28, false, 2010 , "English", "UK", "Warner Bros", 160000000);
            Film film17 = new Film("Rymdimperiet slår tillbaka", "Sci-Fi", 2.04, false, 1980 , "English", "US", "Lucasfilm", 18000000);
            Film film18 = new Film("Matrix", "Action", 2.16, false, 1999 , "English", "Australia", "Warner Bros", 63000000);
            Film film19 = new Film("Maffiabröder", "Drama", 2.25, false, 1990 , "English", "US", "Warner Bros", 25000000);
            Film film20 = new Film("Seven", "Thriller", 2.07, false, 1995 , "English", "US", "Cecchi Gori Pictures", 33000000);
            Film film21 = new Film("Livet är underbart", "Drama", 2.10, false, 1946 , "English", "US", "Liberty Films", 3180000);

                
            films.Add(film1);
            films.Add(film2);
            films.Add(film3);
            films.Add(film4);
            films.Add(film5);
            films.Add(film6);
            films.Add(film7);
            films.Add(film8);
            films.Add(film9);
            films.Add(film10);
            films.Add(film11);
            films.Add(film12);
            films.Add(film13);
            films.Add(film14);
            films.Add(film15);
            films.Add(film16);
            films.Add(film17);
            films.Add(film18);
            films.Add(film19);
            films.Add(film20);
            films.Add(film21);

            
        }
        public Film GetFilm(string name)
        {
            foreach(Film film in films)
            {
                if (film.Name == name)
                {
                    return film;
                }
            }
            return null;
        }

        public List<FilmProxy> GetFilmProxy() 
        {
            List < FilmProxy >movieProxy = new List <FilmProxy >();
            foreach (Film movie in films)
            {
                movieProxy.Add(new FilmProxy(this, movie.Name, movie.Description, movie.Year, movie.Budget));
            }
            return movieProxy;   
        }
        public void AddMovieToDatabas(Film film)
        {
            films.Add(film);
        }
    }
}
