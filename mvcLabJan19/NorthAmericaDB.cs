using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcLabJan19
{
    class NorthAmericaDB
    {
        public List<Country> Countries = new List<Country>();

        public NorthAmericaDB()
        {
            string[] usColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("USA", "English", "Hello World", usColors));
            string[] mexColors = { "Red", "White", "Green" };
            Countries.Add(new Country("Mexico", "Spanish", "Hola Mundo", mexColors));
            string[] canColors = { "Red", "White" };
            Countries.Add(new Country("Canada", "English and French", "Hello World and Bonjour Monde", canColors));
            string[] cubColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("Cuba", "Spanish", "Hola Mundo", cubColors));
            string[] crColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("Costa Rica", "Spanish", "Hola Mundo", crColors));
        }
    }
}
