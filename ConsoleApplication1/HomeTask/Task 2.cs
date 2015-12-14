using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class Task_2
    {
        public static void dayCongrats()
        {
            DayOfWeek currentDay = DateTime.Today.DayOfWeek;
            
            switch (currentDay)
            {
                case DayOfWeek.Monday:
                    {
                        Console.WriteLine("Поздравляем сегодня понедельник");
                        break;

                    }
                case DayOfWeek.Tuesday:
                    {
                        Console.WriteLine("Поздравляем сегодня вторник");
                        break;
                    }

                case DayOfWeek.Wednesday:
                    {
                        Console.WriteLine("Поздравляем сегодня среда");
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        Console.WriteLine("Поздравляем сегодня четверг");
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        Console.WriteLine("Поздравляем сегодня пятница");
                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        Console.WriteLine("Поздравляем сегодня суббота");
                        break;
                    }
                case DayOfWeek.Sunday:
                    {
                        Console.WriteLine("Поздравляем сегодня воскресенье ");
                        break;
                    }
            }
        }
    }
}