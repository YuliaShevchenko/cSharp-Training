using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class HourPaymentWorker : Worker
    {
        public HourPaymentWorker(int id, string name, double salary) : base (id, name, salary)
        {
            TYPE = "hour";
        }

        public override double MonthAvarageSalary()
        {
            return 20.8 * 8 * Salary;
        }

    }
}
