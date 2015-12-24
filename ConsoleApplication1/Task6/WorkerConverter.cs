using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class WorkerConverter
    {

        public static String toString(Worker worker)
        {
            int id = worker.ID;
            string name = worker.Name;
            string type = "";
            double salary = 0;

            if (worker is HourPaymentWorker)
            {
                type = "hour";
                salary = ((HourPaymentWorker)worker).hourPayment;
            }
            else if (worker is MonthPaymentWorker)
            {
                type = "month";
                salary = ((MonthPaymentWorker)worker).monthPayment;
            }

            return id + "," + name + "," + type + "," + salary;
        }

        public static Worker toWorker(String str)
        {
            string[] parts = str.Split(',');
            int id = Convert.ToInt32(parts[0]);
            string name = parts[1];
            string type = parts[2];
            double salary = Convert.ToDouble(parts[3]);

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
