using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            int a = Convert.ToInt32((Console.ReadLine()));
            int b = Convert.ToInt32((Console.ReadLine()));

            int count = 0;
            int sum = 0;
            for (int x = a; x < b; x++)
                if (x % 3 == 0)
                {
                    count = count + 1;
                    sum = sum + x;
                }
            Console.WriteLine(count);

            //Task2



            //Task3
            //Task4
            //Task5
            //Task6
            //Task7
            //Task8
            //Task9
            //Task10

        }
    }
}
