using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_of_volumes_of_rectangular_parallelepipeds
{
    class Program
    {
        static int Difference(int[] a, int[] b)
        {

            int rezult1 = 0;

            int rezult2 = 0;

            int rezult;

            for (int i = 0; i < a.Length; i++)
            {
                rezult1 *= a[i];

            }
            for (int i = 0; i < b.Length; i++)
            {
                rezult1 *= b[i];
            }

            if (rezult1 > rezult2)
            {
                rezult = rezult1 - rezult2;
            }
            else rezult = rezult2 - rezult1;

            return rezult;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers from the first list: ");

            int[] listA = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();


            Console.WriteLine("Enter three numbers of the second list: ");

            int[] listB = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();


            Console.WriteLine(Difference(listA, listB));

            Console.ReadLine();

        }
    }
}
