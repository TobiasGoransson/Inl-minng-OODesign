using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.AddMovieFunktion
{
    public class SettingDescription
    {
        string description = null;
        public SettingDescription()
        {
        }

        public string SettingADescription()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Do you know the genre (Y/N)");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    Console.WriteLine("What genre is the movie");
                    description = Console.ReadLine();

                    loop = false;
                }
                else if (answer == "N")
                {
                    loop = false;

                }
                else
                {
                    Console.WriteLine("You need to choose Y or N");
                }
            }
            return description;
        }
    }
}
