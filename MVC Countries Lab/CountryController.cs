using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb = new List<Country>();
            CountryDb.Add(new Country("USA", Continent.NorthAmerica, new List<ConsoleColor> { ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue }));
            CountryDb.Add(new Country("France", Continent.Europe, new List<ConsoleColor> { ConsoleColor.Blue, ConsoleColor.White, ConsoleColor.Red }));
            CountryDb.Add(new Country("Brazil", Continent.SouthAmerica, new List<ConsoleColor> { ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow }));
            CountryDb.Add(new Country("Italy", Continent.Europe, new List<ConsoleColor> { ConsoleColor.Green, ConsoleColor.White, ConsoleColor.Red }));
            CountryDb.Add(new Country("Venezuela", Continent.SouthAmerica, new List<ConsoleColor> { ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Red }));
        }
        public void CountryAction(Country country)
        {
            CountryView countryView = new CountryView(country);
            countryView.Display();
        }

        public void WelcomeAction()
        {
            CountryViewList countryViewList = new CountryViewList(CountryDb);

            Console.WriteLine("Hello. Welcome to.... THE WORLD.");

            bool a = true;
            while (a)
            {

                Console.WriteLine("What country would you like to learn about?");
                countryViewList.Display();
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input >= 0 && input < countryViewList.Countries.Count)
                    {
                        CountryAction(CountryDb[input]);
                        Console.WriteLine("Would you like to learn about another country?");
                        string input2 = Console.ReadLine().ToLower();
                        if (input2 == "y")
                        {
                            a = true;
                        }
                        else
                        {
                            a = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That input was not an option within parameters.");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("That input was not an option.");
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

        }
        
    }

}

