
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Worker
    {
        public string name, surname;
        public int days, rate;

        public void GetSalary()
        {
            Console.WriteLine($"зпшка -  {days * rate}");
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Worker dima = new Worker();
            dima.name = "Dimka";
            dima.surname = "Kuplinov";
            dima.days = 4;
            dima.rate = 5000;
            dima.GetSalary();
        }
    }
}
