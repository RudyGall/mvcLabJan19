using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcLabJan19
{
    class AsiaDB
    {
        public List<Country> Countries = new List<Country>();

        public AsiaDB()
        {
            string[] chiColors = { "Red", "Gold" };
            Countries.Add(new Country("China", "Chinese", "Nǐ hǎo shìjiè", chiColors));
            string[] jpnColors = { "Red", "White" };
            Countries.Add(new Country("Japan", "Japanese", "Kon'nichiwa sekai", jpnColors));
            string[] vietColors = { "Red", "Yellow" };
            Countries.Add(new Country("Vietnam", "Vietnamese", "Chào thế giới", vietColors));
            string[] nkColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("North Korea", "Korean", "annyeong sesang", nkColors));
            string[] skColors = { "Red", "White", "Blue", "Black" };
            Countries.Add(new Country("South Korea", "Korean", "annyeong sesang", nkColors));
        }
    }
}
