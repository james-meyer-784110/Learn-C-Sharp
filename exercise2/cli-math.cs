using System;

namespace CliMathApp
{
    class CliMath
    {
        public static double add(double[] n)
        {
            double sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n;
            }
            return sum;
        }

        public static double sub(double[] n)
        {
            double r = 0;
            for (int i = 0; i < n.Length; i++)
            {
                r -= n;
            }
            return r;
        }

        public static T[] subArray(T[] array, int start, int end)
        {
            T[] subArray = new T[end - start];

            for (int i = start; i < end; i++)
            {
                subArray[i] = array[i];
            }

            return subArray;
        }

        public static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.Error("Insufficient arguments!");
            }

            if (args[0].Equals("add"))
            {

            }
            else if (args[0].Equals("sub"))
            {

            }
        }
    }
}