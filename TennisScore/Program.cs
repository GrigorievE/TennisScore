using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello.");
            Console.WriteLine("Who Serve First??? 1 or 2");
            Serve.Who = Convert.ToInt32(Console.ReadKey()); //добавить обработку исключений
            //public Match match;
            
        
            //do
            //{
            //    Console.WriteLine("Who Win Point??? 1 or 2");
            //    Serve.Who = Convert.ToInt32(Console.ReadKey()); //добавить обработку исключений
            //} 
            //while (!match.End);


            Console.ReadKey();
        }
    }
}
