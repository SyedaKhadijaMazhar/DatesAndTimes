using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
          //  DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue);
            // Console.WriteLine(myValue.ToShortDateString());
            //  Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //  Console.WriteLine(myValue.ToLongTimeString());
            // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            // Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //   Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            //Console.WriteLine(myValue.Month);
            // DateTime myBday = new DateTime(1995, 4, 2);
            //Console.WriteLine(myBday.ToShortDateString());
            //   Console.WriteLine(myBday.ToLongDateString());
            DateTime myBday =  DateTime.Parse("1995/4/2");
            TimeSpan myAge = DateTime.Now.Subtract(myBday);
            Console.WriteLine(myAge.TotalDays);

            Console.ReadLine();
        }
    }
}
