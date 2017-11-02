using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;

namespace _0._16_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            //Instructor Array
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;


            //Iterate through the array using the query
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1,Name="Johnboy", HireDate = new DateTime(2016,3,5)},
                new Employee {ID=2,Name="Ladasha", HireDate = new DateTime(2016,2,14)},
                new Employee {ID=3,Name="Shhqwan", HireDate = new DateTime(2016,12,3)},
                new Employee {ID=4,Name="Old Man Jenkins", HireDate = new DateTime(2016,6,3)},
                new Employee { ID = 2, Name = "A A Ron Bah Lah K", HireDate = new DateTime(2016,1,20)},
            };

            IEnumerable<Employee> eQuery = from e in employees
                                           where e.HireDate.Year == 2016
                                           orderby e.Name ascending
                                           select e;

            foreach (Employee employee in eQuery)
            {
                Console.WriteLine(employee.Name);
                synth.Speak($"{employee.Name}");
            }
            Console.ReadLine();
        }
    }
}
