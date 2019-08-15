using System;

namespace DataTypesApp
{
    class DataTypes
    {
        public static void Main(string[] args)
        {

            {
                bool a = true;
                bool b = false;
                Console.WriteLine("{0}", a & b);
                Console.WriteLine("{0}", a | b);
                Console.WriteLine("{0}", !a & b);
            }

            {
                int a = 2;
                int b = 10;
                int c = (a * a) + (b * b);
                Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            }

        }
    }
}