using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLenkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[] { "b", "c", "d", "e", "f", "g", "h" };
            int k, l;
            
            k=Calculate(a);
            l=Calculate2(a);
            
            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }

        private static int Calculate2(string[] a)
        {
            int start = 0, max = a.Length;
            int value1 = 0, value2 = 0;

            for (int i = 5; i < start; --i)
            {
                if (a[i] != a[0])
                {
                    value2 = value2 + 1;
                }
                else if (a[i] == a[0])
                {
                    break;
                }
            }
            return value2;

        }

        private static int Calculate(string[] a)
        {
            int start = 0, max = a.Length-1;
            int value1 = 0, value2 = 0;
            int n = 5;

            for ( int i=0; i <= max; i++)
            {
                if (a[i] != a[0])
                {
                    value1 = value1 + 1;
                }
                else if (a[i] == a[0])
                {
                    break;
                }

                if (i== max)
                {
                    max = 0;
                    n = 0;
                }
            }
            return value1;

        }
    }
}
