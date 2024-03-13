using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.AddMovieFunktion
{
    internal class SettingCountryOfOrigin
    {
        string contryOfOrigine = null;
        public string SettingACountryOfOrigin() 
        {
           bool loop = true;
            while (loop)
            {
                Console.WriteLine("Do you know the Country of origin (Y/N)");
                string answer5 = Console.ReadLine();
                if (answer5 == "Y")
                {
                    Console.WriteLine("Type the Country of origin");
                    contryOfOrigine = Console.ReadLine();
                    
                    loop = false;
                }
                else if (answer5 == "N")
                {
                    loop = false;

                }
                else
                {
                    Console.WriteLine("You need to choose Y or N");
                }
            }
            return contryOfOrigine;
        }
    }
}
