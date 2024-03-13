using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.AddMovieFunktion
{
    public  class SettingLanguage
    {
        string language = null;
        public string SettingALanguage()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Do you know the language (Y/N)");
                string answer4 = Console.ReadLine();
                if (answer4 == "Y")
                {
                    Console.WriteLine("type the movies language");
                    language = Console.ReadLine();
                   
                    loop = false;
                }
                else if (answer4 == "N")
                {
                    loop = false;

                }
                else
                {
                    Console.WriteLine("You need to choose Y or N");
                }
            }
            return language;
        }
    }
}
