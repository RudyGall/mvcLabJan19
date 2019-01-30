using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcLabJan19
{
    class CountryController
    {
        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);
            cd.Display();  
        }
        public void CountryMenu()
        {
            Console.WriteLine("What continent would you like to learn about?(North america or Asia)");
            List<Country> countries;
            string input = Console.ReadLine();

            if(input.ToLower()=="north america")
            {
                NorthAmericaDB nadb = new NorthAmericaDB();
                countries = nadb.Countries;
                foreach (Country c in countries)
                {
                    CountryDetails cc = new CountryDetails(c);
                    cc.Display();
                }              
            }
            else if(input.ToLower()=="asia")
            {
                AsiaDB adb = new AsiaDB();
                countries = adb.Countries;
                foreach (Country c in countries)
                {
                    CountryDetails cc = new CountryDetails(c);
                    cc.Display();
                }
            }
        }
    }
}