using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcLabJan19
{
    class CountryDetails
    {
        Country Country;
        public CountryDetails(Country Country)
        {
            this.Country = Country;
        }
        public void Display()
        {
            Console.WriteLine("Country: " + Country.Name);                    
        }
        public void Display2()
        {
            Console.WriteLine("Language: " + Country.Lang);
        }
        public void Display3()
        {
            Console.WriteLine("Greeting: " + Country.Hello);
        }
        public void Display4()
        {
            Console.WriteLine("Colors: ");
            foreach (string color in Country.Colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
