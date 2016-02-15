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
            ////Task 1
            //string enteredText = Task1.method1("Home Task");
            //Console.WriteLine(enteredText);
            //string enteredValue = Task1.method1(5);
            //Console.WriteLine(enteredValue);
            //Console.WriteLine("----------------------------");

            ////Task 2
            //Task_2.dayCongrats();
            //Console.WriteLine("----------------------------");


            ////Task3
            //Task3.splitMethod();

            //Console.ReadKey();

            int[] arr = {1,1,9,8, 7, 6, 5, 4, 3,  2};

            for (int i = 0; i < arr.Length;i++ )
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if(arr[j]>arr[j+1]){
                        int x = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = x;
                    }
                }
            }

            int[] arr2 = { 1, 1, 9, 8, 7, 6, 5, 4, 3, 2 };

            for (int i = 0; i < arr2.Length-1; i++)
            {
                int min = arr2[i];
                int minindex = i;

                for (int j = i+1; j < arr2.Length; j++)
                {
                    if (min > arr2[j]) { 
                         min = arr[j];
                         minindex = j;
                    }                    
                }

                int x = arr2[i];
                arr2[i] = arr2[minindex];
                arr2[minindex] = x;

            }

            foreach (int item in arr2)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }

        }
        }
    }

