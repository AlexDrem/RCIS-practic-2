using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2._5
{

    class chtoto {
        private string name;
        private string surname;

        public chtoto() { name = "Неизвестно"; surname = "Неизвестно"; }
        public chtoto(string name,string surname) { this.name = name; this.surname = surname; }

        public void GetPrint()
        {
            Console.WriteLine($"Имя: {name}  Фамилия: {surname}");
        }

        ~chtoto()
        {
            Console.WriteLine($"{name} has deleted");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            chtoto d1 = new chtoto("Dmitry","Kuplinov");
            chtoto d2 = new chtoto();
            d1.GetPrint();
            d2.GetPrint();
            Console.WriteLine("Димка лучший");


        }
    }
}
