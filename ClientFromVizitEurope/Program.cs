using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientFromVizitEurope.ServiceVizitEurope;

namespace ClientFromVizitEurope
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new NightPricesServiceSoapClient();
            List<country> countruList = new List<country>(); 
            foreach (country country in client.DictionaryCountries()) {
                Console.WriteLine("id - {0}\tcode - {1}\ttitle - {2}\tupdate - {3}", country.id, country.code, country.title, country.updated);
                countruList.Add(country);
            }
            Console.WriteLine("Count country {0}",countruList.Count);
            Console.ReadKey();
        }
    }
}
