using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inläminng_OODesign.AddMovieFunktion
{
    public class SettingYear
    {
        bool isNew;
        int year;
       

        public SettingYear() { }

        public int SettingAYear()
        {
            Console.WriteLine("Is the movie new (Y/N)");
            string answer1 = Console.ReadLine();
            isNew = answer1.ToUpper() == "Y";
            DateTime dateTime = DateTime.Now;
            year = dateTime.Year;

            if (!isNew)
            {
                Console.WriteLine("Do you know the year (Y/N)");
                string answer2 = Console.ReadLine();
                if (answer2 == "Y")
                {
                    Console.WriteLine("Type the Year");
                    year = int.Parse(Console.ReadLine());
                    
                }
                else
                {
                    year = 0;
                }
            }
            return year; 
        }
    }
}
