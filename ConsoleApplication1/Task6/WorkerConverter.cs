using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class WorkerConverter
    {
        public static Worker toWorker(String str)
        {
            string[] parts;
            int id;
            string name;
            string type;
            double salary;

            try
            {
                parts = str.Split(',');
                id = Convert.ToInt32(parts[0]);
                name = parts[1];
                type = parts[2];
                salary = Convert.ToDouble(parts[3]);
            }
            catch
            {
                throw new FormatException ("Invalid string format");
            }

            if (type == "month")
            {
                return new MonthPaymentWorker(id, name, salary);
            }
            else if (type == "hour")
            {
                return new HourPaymentWorker(id, name, salary);
            }
            else
            {
                return null;
            }
        }

    }
}
