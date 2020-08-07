using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry; 
        }
        public void Display()
        {
            Console.WriteLine("Hello. Welcome to.... THE WORLD.");
            Console.WriteLine($"Country: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            foreach(ConsoleColor color in DisplayCountry.Colors)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(color);
                Console.ResetColor();
            }
        }
    }
}
