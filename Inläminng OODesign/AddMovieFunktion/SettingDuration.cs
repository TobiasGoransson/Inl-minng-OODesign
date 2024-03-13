using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.AddMovieFunktion
{
    public class SettingDuration
    {
        public double duration = 0;
        public double SettingADuration()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Do you know how long the movie is (Y/N)");
                string answer3 = Console.ReadLine();
                if (answer3 == "Y")
                {
                    Console.WriteLine("How long is the Movie in hours");
                    duration = double.Parse(Console.ReadLine());
                    
                    loop = false;
                }
                else if (answer3 == "N")
                {
                    loop = false;

                }
                else
                {
                    Console.WriteLine("You need to choose Y or N");
                }
            }
            return duration;
        }
    }
}
