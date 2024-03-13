using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.AddMovieFunktion
{
    public class SettingBudget
    {
        int budget = 0;
        public int SettingABudget()
        {

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Do you know how big the budget was (Y/N)");
                string answer7 = Console.ReadLine();
                if (answer7 == "Y")
                {
                    Console.WriteLine("How much was the budget");
                    budget = int.Parse(Console.ReadLine());
                    
                    loop = false;
                }
                else if (answer7 == "N")
                {
                    loop = false;

                }
                else
                {
                    Console.WriteLine("You need to choose Y or N");
                }
            }
            return budget;
        }
    }
}
