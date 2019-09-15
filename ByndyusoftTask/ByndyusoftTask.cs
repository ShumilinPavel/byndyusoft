using System;

namespace ByndyusoftTask
{
    public class ByndyusoftTask
    {
        public static long GetSumOfTwoMins(long[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Array is empty. At least 2 numbers are expected.");
            if (numbers.Length == 1)
                throw new ArgumentException("Array has 1 number. At least 2 numbers are expected.");

            var min1 = numbers[0];
            var min2 = numbers[1];

            if (min2 < min1)
            {
                var tmp = min1;
                min1 = min2;
                min2 = tmp;
            }

            for (var i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] < min1)
                {
                    min2 = min1;
                    min1 = numbers[i];
                }
                else if (numbers[i] < min2)
                    min2 = numbers[i];
            }

            return min1 + min2;
        }

        static void Main()
        {
            var numbers = new long[] { 4, 0, 3, 19, 492, -10, 1 };
            Console.WriteLine(GetSumOfTwoMins(numbers));
        }
    }
}
