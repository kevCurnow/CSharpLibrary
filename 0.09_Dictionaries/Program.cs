using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type a year in the space below to show the movie that won: ");
            var year = Console.ReadLine();

            //Console.Write("Please type a year to show the movies that were up for an award that year: ");
            //var yearNom = Console.ReadLine();
            Dictionary<string, string> winners = new Dictionary<string, string>();


            winners.Add("2000", "Gladiator");
            winners.Add("2001", "A Beautiful Mind");
            winners.Add("2002", "Chicago");
            winners.Add("2003", "The Lord of the Rings: The Return of the King");
            winners.Add("2004", "Million Dollar Baby");
            winners.Add("2005", "Crash");


                

            //foreach (KeyValuePair<int, string> element in winners)
            //{
            //    Console.WriteLine($"{element.Key.ToString()}: {element.Value}");
            //}

            //Dictionary<string, string> values = new Dictionary<string, string>();

            //string[] noms = { "Gladiator; ", "Chocolat; ", "Crounching Tiger, Hidden Dragon; ", "Erin Brockovich; ", "Traffic" };
            //string result = String.Concat(noms);

            //values.Add("2000", result);

            //foreach (KeyValuePair<string, string> pair in values)
            //{
            //    Console.Write("{0}: {1}", pair.Key, pair.Value);
            //}

            Console.WriteLine(winners[year]);

            Console.ReadLine();

            Console.Write("Please type a year to see the movies nominated for best picture: ");
            var yearNom = Console.ReadLine();

            Dictionary<string, string> nominees = new Dictionary<string, string>();

            string[] noms00 = { "Gladiator; ", "Chocolat; ", "Crounching Tiger, Hidden Dragon; ", "Erin Brockovich; ", "Traffic" };
            string noms00cat = String.Concat(noms00);
            nominees.Add("2000", noms00cat);



            Console.WriteLine(nominees[yearNom]);

            Console.ReadLine();
        }
    }
}
