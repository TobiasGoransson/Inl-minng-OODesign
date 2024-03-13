using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.Choises
{
    public class Quit : IChoice
    {
        public void Choice()
        {
            Console.WriteLine("Back to Main Menu");
        }

        public string GetDescription()
        {
           return "Q. To quit";
        }
    }
}
