using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryViewList
    {
        public List<Country> Countries { get; set; }

        public CountryViewList()
        {

        }
        public CountryViewList(List<Country> Countries)
        {
            this.Countries = Countries; 
        }
        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++ )
            {
                Console.WriteLine($"{i}: {Countries[i].Name}"); 
            }
        }

    }
}
