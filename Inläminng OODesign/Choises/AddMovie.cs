using Inläminng_OODesign.AddMovieFunktion;
using Inläminng_OODesign.Choises.AddMovieChoice;
using Inläminng_OODesign.Choises.SortChoise;
using System.Diagnostics.Metrics;

namespace Inläminng_OODesign.Choises
{
    public class AddMovie : IChoice
    {

        Database db;

        Dictionary<string, IChoice> AddMoviechoices = new Dictionary<string, IChoice>();

        public AddMovie(Database db)
        {
            this.db = db;
            AddMoviechoices.Add("1", new MakeCopy(db));
            AddMoviechoices.Add("2", new RegisterManually(db));
            AddMoviechoices.Add("Q", new Quit());
        }

        public void Choice()
        {
            AddMovieMenu();
        }

        public string GetDescription()
        {
            return "3. Add a Movie";
        }

        public void AddMovieMenu()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Welcome to the movie databas!");
                Console.WriteLine();

                foreach (IChoice choice1 in AddMoviechoices.Values.ToList())
                {
                    Console.WriteLine(choice1.GetDescription());
                }

                string choice = Console.ReadLine();

                if (AddMoviechoices.ContainsKey(choice))
                {
                    AddMoviechoices[choice].Choice();
                    if (AddMoviechoices[choice] is Quit)
                    {
                        loop = false;
                    }
                }
                else
                {
                    Console.WriteLine("Make a choise from the menu");
                }
              
            }
        }
    }
}