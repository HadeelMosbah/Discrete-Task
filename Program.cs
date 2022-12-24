using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Enter Starting Number : ");

            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ending Number : ");

            n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)

            {

                long sum = 0;

                for (int j = 1; j < i; j++)

                {

                    if (i % j == 0)

                        sum = sum + j;

                }

                if (sum == i)

                    Console.WriteLine("The perfect number is:" + i);

            }
        }
    }
}
