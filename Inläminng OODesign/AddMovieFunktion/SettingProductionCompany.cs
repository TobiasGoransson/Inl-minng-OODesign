using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.AddMovieFunktion
{
    public class SettingProductionCompany
    {
        public string productionCompany = null;
        public string SetttingAProductionCompany() 
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Do you know the who made it (Y/N)");
                string answer6 = Console.ReadLine();
                if (answer6 == "Y")
                {
                    Console.WriteLine("Type the production company ");
                    productionCompany = Console.ReadLine();
                    
                    loop = false;
                }
                else if (answer6 == "N")
                {
                    loop = false;

                }
                else
                {
                    Console.WriteLine("You need to choose Y or N");
                }
            }
            return productionCompany;
        }
    }
}
