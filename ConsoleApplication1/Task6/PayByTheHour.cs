using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class PayByTheHour : Workers
    {
        double hourPayment;
        

         public PayByTheHour(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            hourPayment = salary;
        }

        public override double MonthAvarageSalary()
        {
            double monthSalary = 20.8 * 8 * hourPayment;
            return monthSalary;
        }

    }
}
