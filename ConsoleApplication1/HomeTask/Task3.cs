using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class Task3
    {
        public static void splitMethod()
        {
            DateTime currentDayTime = DateTime.Now;
            string dayLongFormat = currentDayTime.ToString("D", CultureInfo.CreateSpecificCulture("en-US"));

            string[] result = dayLongFormat.Split(',');
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i].Trim());
            }

        }
    }
}
