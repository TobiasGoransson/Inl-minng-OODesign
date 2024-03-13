using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inläminng_OODesign.Choises;
using Inläminng_OODesign.SortAlgorithm;

namespace Inläminng_OODesign
{
    public class MovieMain
    {
        Database db = new Database();
        Dictionary<string, IChoice> choices = new Dictionary<string, IChoice>();
        public MovieMain() 
        {
            choices.Add("1", new ListOfMovies(db));
            choices.Add("2", new SortListOfMovies(db));
            choices.Add("3", new AddMovie(db));
            choices.Add("Q", new Quit());
            
        }
        public void run()
        {
            MovieMenu();

        }
        


        public void MovieMenu()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Welcome to the movie databas!");
                Console.WriteLine();

                foreach (IChoice choice1 in choices.Values.ToList())
                {
                    Console.WriteLine(choice1.GetDescription());
                }

                string choice = Console.ReadLine();

                if (choices.ContainsKey(choice))
                {
                    choices[choice].Choice();
                    if (choices[choice] is Quit)
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
