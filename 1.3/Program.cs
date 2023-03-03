using System;

namespace ConsoleApp1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            string str;
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
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
