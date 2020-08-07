using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<ConsoleColor> Colors { get; set; }

        public Country()
        {

        }

        public Country(string Name, Continent Continent, List<ConsoleColor> Colors)
        {
            this.Name = Name;
            this.Continent = Continent;
            this.Colors = Colors;
        }
    }

    public enum Continent
    {
        NorthAmerica,
        SouthAmerica,
        Europe,
        Asian,
        Austrailia,
        Africa,
        Antartica, 
    }
}
