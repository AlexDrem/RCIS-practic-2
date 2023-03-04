using System;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string str;
            int[] nums = { 8, 3, 1, 5, 9, 3, 7, 6, 2, 7 };
            bool a = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    a = true;
                }
            }

            if (a == false)
            {
                str = "False";
            }
            else
            {
                str = "True";
            }

            Console.WriteLine(str);
        }
    }
}
