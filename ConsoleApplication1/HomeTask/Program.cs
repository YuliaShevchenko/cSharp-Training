using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string enteredText = Task1.method1("Home Task");
            Console.WriteLine(enteredText);
            string enteredValue = Task1.method1(5);
            Console.WriteLine(enteredValue);
            Console.WriteLine("----------------------------");

            //Task 2
            Task_2.dayCongrats();
            Console.WriteLine("----------------------------");


            //Task3
            Task3.splitMethod();

            Console.ReadKey();
        }
    }
}
