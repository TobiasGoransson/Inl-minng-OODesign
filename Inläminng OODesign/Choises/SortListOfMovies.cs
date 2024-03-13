using Inläminng_OODesign.Choises.SortChoise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises
{
    public class SortListOfMovies : IChoice
    {
        Database db;
        Dictionary<string, IChoice> Sortchoices = new Dictionary<string, IChoice>();
        public SortListOfMovies(Database db)
        {
            this.db = db;
            Sortchoices.Add("1", new SortByName(db));
            Sortchoices.Add("2", new SortByDescription(db));
            Sortchoices.Add("3", new SortByYear(db));
            Sortchoices.Add("4", new SortByBudget(db));
            Sortchoices.Add("Q", new Quit());
        }

        public void Choice()
        {
            MovieSortMenu();
        }

        public string GetDescription()
        {
            return "2. Sort list of Movies";
        }


        public void MovieSortMenu()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("How do you whant to sort the list");
                Console.WriteLine();



                foreach (IChoice choice1 in Sortchoices.Values.ToList())
                {
                    Console.WriteLine(choice1.GetDescription());
                }

                string choice = Console.ReadLine();

                if (Sortchoices.ContainsKey(choice))
                {
                    Sortchoices[choice].Choice();
                    if (Sortchoices[choice] is Quit)
                    {
                        loop = false;
                    }
                }
                else
                {
                    Console.WriteLine("Choose a selection from the Menu");
                }
               
            }
        }

        
    }
}
