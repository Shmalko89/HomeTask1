using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Представьтесь, пожалуйста!");
            string name = Console.ReadLine();
            Console.WriteLine($"Приветствую, {name}! Сегодня {DateTime.Now.ToString("D")}");
        }
    }
}
