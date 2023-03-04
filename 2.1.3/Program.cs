using System;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string str;
            int[] nums = { 2, 4, 1, 3, 1, 4, 3, 2, 1, 3 };
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
