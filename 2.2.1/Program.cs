using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public string familia, data;
        public int nomer;
        public int[] yspevaimost;

        public void writeInConsoleInfo(string familia, string data, int nomer, int[] yspevaimost)
        {
            Console.WriteLine("Фамилия: {0}\nДень рождение: {1}\nГруппа: {2}\n", familia, data, nomer);
            Console.WriteLine("Успеваемость:");
            foreach (int i in yspevaimost)
            {
                Console.Write(i + " ");
            }
        }


    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Student alexandr = new Student();
            alexandr.familia = "dremov";
            alexandr.data = "21.11.2003";
            alexandr.nomer = 623;
            alexandr.yspevaimost = new[] { 2, 3, 3, 3, 3 };

            
            bool rabota = true;
            while (rabota)
            {
                Console.WriteLine("Введите 1: для вывода, 2: для изменения данных");
                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        alexandr.writeInConsoleInfo(alexandr.familia, alexandr.data, alexandr.nomer,
                            alexandr.yspevaimost);
                        
                        break;
                    case "2":
                        Console.WriteLine("Введите 1 для изменения фамилии, 2 дня рождения, 3 группы, 0 для вывода");
                        string b = Console.ReadLine();
                        {
                            switch (b)
                            {
                                case "1":
                                    Console.WriteLine("Введите новую фамилию");
                                    string newfamilia = Console.ReadLine();
                                    alexandr.familia = newfamilia;
                                    break;
                                case "2":
                                    Console.WriteLine("Введите новую дату дня рождения");
                                    string newdata = Console.ReadLine();
                                    alexandr.data = newdata;
                                    break;
                                case "3":
                                    Console.WriteLine("Введите новую группу");
                                    int newnomer = Convert.ToInt32(Console.ReadLine());
                                    alexandr.nomer = newnomer;
                                    break;
                                case "0":
                                    alexandr.writeInConsoleInfo(alexandr.familia, alexandr.data, alexandr.nomer,
                                        alexandr.yspevaimost);
                                    
                                    break;
                            }
                        }
                        break;

                }
            }

        }
    }
}
