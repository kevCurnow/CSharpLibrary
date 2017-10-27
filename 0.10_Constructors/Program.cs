using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student jayStudent = new Student("Jay", "Jackson", 5, 1);
            Student paulStudent = new Student("Paul", "O'Connor", 12);
            Student kevinStudent = new Student("Kevin");
            Student joeStudent = new Student(23, "Joe", "Bir");
            Console.WriteLine(jayStudent.LastName);

            MobilePhone phone1 = new MobilePhone("Samsung", "Galaxy S8");
            MobilePhone phoneBob = new MobilePhone("Bob", "iPhone", "8");
            MobilePhone phoneJoe = new MobilePhone("Joe", "Samsung", "Galaxy S6");
            MobilePhone phoneBill = new MobilePhone("Bill", "Nokia", "Smartphone");
            MobilePhone phoneSteve = new MobilePhone("Steve", "Blackberry", "Pie");
            MobilePhone phoneGeorge = new MobilePhone("George", "Motorola", "Razr");

            List<MobilePhone> phones = new List<MobilePhone>() { phoneBob, phoneJoe, phoneBill, phoneSteve, phoneGeorge };
          

            foreach (MobilePhone phone in phones)
            {
                Console.WriteLine(phone.GetPhone());
            }


            Console.ReadLine();


        }
    }
}
