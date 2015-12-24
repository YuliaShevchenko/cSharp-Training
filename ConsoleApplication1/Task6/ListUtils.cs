using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class ListUtils
    {
        //sorting by salary
        private class SalaryCompator : IComparer<Worker>
        {
            int IComparer<Worker>.Compare(Worker x, Worker y)
            {
                return y.MonthAvarageSalary().CompareTo(x.MonthAvarageSalary());
            }
        }

        //alphabetical sorting by name
        private class NameCompator : IComparer<Worker>
        {
            int IComparer<Worker>.Compare(Worker x, Worker y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public static List<Worker> SortBySalaryAndName(List<Worker> list)
        {
            List<Worker> newList = new List<Worker>(list);
            newList.Sort(new ListUtils.NameCompator());
            newList.Sort(new ListUtils.SalaryCompator());
            return newList;
        }
       
        public static List<Worker> getTop5(List<Worker> list)
        {
            List<Worker> newList = new List<Worker>();
            for (int i = 0; i < 5; i++)
            {
                newList.Add(list[i]);
            }
            return newList;
        }

        public static List<Worker> getLast3(List<Worker> list)
        {
            List<Worker> newList = new List<Worker>();
            for (int i = list.Count - 3; i < list.Count; i++)
            {
                newList.Add(list[i]);
            }
            return newList;
        }
    }
}
