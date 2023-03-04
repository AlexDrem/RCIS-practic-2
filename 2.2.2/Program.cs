using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Train
    {
        public string pynkt, vremya;
        public int nomer;

        public void writeInConsoleInfo(string pynkt, string vremya, int nomer)
        {
            Console.WriteLine("Номер поезда: {0}\nВремя: {1}\nПункт: {2}", nomer, vremya, pynkt);
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            Train train1 = new Train();
            train1.pynkt = "Moscow";
            train1.nomer = 1;
            train1.vremya = "7:30";

            Train train2 = new Train();
            train2.pynkt = "Tomsk";
            train2.nomer = 2;
            train2.vremya = "10:00";

            Train train3 = new Train();
            train3.pynkt = "Sankt-Peterburg";
            train3.nomer = 3;
            train3.vremya = "15:00";

            bool rabota = true;
            while (rabota)
            {

                Console.WriteLine("Введите номер поезда от 1 до 3");
                string chislo = Console.ReadLine();

                switch (chislo)
                {
                    case "1":
                        train1.writeInConsoleInfo(poezd1.pynkt, train1.vremya, train1.nomer);
                        break;
                    case "2":
                        train2.writeInConsoleInfo(poezd2.pynkt, train2.vrema, train2.nomer);
                        break;
                    case "3":
                        train3.writeInConsoleInfo(poezd3.pynkt, train3.vremya, train3.nomer);
                        break;
                }
            }
        }
    }
}
