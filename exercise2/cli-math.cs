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
                sum += n[i];
            }
            return sum;
        }

        public static double sub(double[] n)
        {
            double r = 0;
            for (int i = 0; i < n.Length; i++)
            {
                r -= n[i];
            }
            return r;
        }

        // TODO: this method has multiple points of failure
        public static T[] subArray<T>(T[] array, int start, int end)
        {
            T[] subArray = new T[end - start];

            for (int i = start; i < end; i++)
            {
                subArray[i] = array[i];
            }

            return subArray;
        }

        // TODO: this method can fail on parsing
        public static double[] fromStrings(string[] nums){
            double[] n = new double[nums.Length];

            for(int i = 0; i < nums.Length; i++){
                n[i] = Double.Parse(nums[i]);
            }

            return n;
        }

        public static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Insufficient arguments!");
            }
            // collect the numbers
            string[] nums = subArray<string>(args, 1, args.Length);
            // various math functions
            if (args[0].Equals("add"))
            {
                Console.WriteLine("{0}", add(fromStrings(nums)));    
            }
            else if (args[0].Equals("sub"))
            {
                Console.WriteLine("{0}", sub(fromStrings(nums)));
            }
        }
    }
}