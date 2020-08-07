using System;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController cc = new CountryController();

            while (true)
            {
                cc.WelcomeAction();

                break;
            }
            
        }
    }
}
