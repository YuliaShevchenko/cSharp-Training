using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class HourPaymentWorker : Worker
    {
        public double hourPayment;

        public HourPaymentWorker(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            hourPayment = salary;
        }

        public override double MonthAvarageSalary()
        {
            return 20.8 * 8 * hourPayment;
        }

    }
}
