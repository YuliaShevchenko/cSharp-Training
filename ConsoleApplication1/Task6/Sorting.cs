using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Sorting
    {
        //sorting by salary
        public class salaryCompator : IComparer<Workers>
        {
            int IComparer<Workers>.Compare(Workers x, Workers y)
            {
                return y.MonthAvarageSalary().CompareTo(x.MonthAvarageSalary());
            }
        }

        //alphabetical sorting by name
        public class nameCompator : IComparer<Workers>
        {
            int IComparer<Workers>.Compare(Workers x, Workers y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public static List<Workers> SortingBySalaryAndName(List<Workers> list)
        {
            Sorting.nameCompator sortByname = new Sorting.nameCompator();
            Sorting.salaryCompator sortBySalary = new Sorting.salaryCompator();
            list.Sort(sortByname);
            list.Sort(sortBySalary);
            return list;

        }
        public static void showAll(List<Workers> list)
        {
            foreach (Workers worker in list)
            {
                Console.WriteLine(worker.ID + " - " + worker.Name + " - " + worker.MonthAvarageSalary());
            }

        }
        public static List<Workers> getTop5(List<Workers> list)
        {
            List<Workers> listTop5 = new List<Workers>();
            for (int i = 0; i < 5; i++)
            {
                listTop5.Add(list[i]);
            }
            return listTop5;

        }
        public static List<Workers> getLast3(List<Workers> list)
        {
            List<Workers> listLast3 = new List<Workers>();
            for (int i = list.Count - 3; i < list.Count; i++)
            {
                listLast3.Add(list[i]);
            }
            return listLast3;

        }
    }
}
