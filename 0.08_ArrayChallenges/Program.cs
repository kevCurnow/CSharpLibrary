using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_ArrayChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] randArray = new int[10];
            System.Random rnd = new System.Random();
            for (int i = 0; i < randArray.Length; i++)
            {
                randArray[i] = rnd.Next(0, 20);
            }
            foreach (int element in randArray)
            {
                Console.WriteLine(element);
            }
            //int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] array2 = new int[] { 6, 7, 8, 9, 10 };
            //int[] sum = new int[5];
            //for (int i = 0; i < sum.Length; i++)
            //{
            //    sum[i] = array1[i] + array2[i];
            //}
            //foreach (int element in sum)
            //{
            //    Console.WriteLine(element);
            //}
            Console.ReadLine();

            //string[] foods = new string[] { "pizza", "peanut butter", "ice-cream" };
            //foreach (string element in foods)
            //{
            //    Console.WriteLine(element);
            //}
            //Console.ReadLine();
        }
    }
}
