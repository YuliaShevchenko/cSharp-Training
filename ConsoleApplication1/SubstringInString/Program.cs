using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter some text");
            string usersText = Console.ReadLine();
            Console.WriteLine("Please, enter any part of the text");
            string partOftext = Console.ReadLine();
            bool presenceInText = usersText.Contains(partOftext);
            Console.WriteLine(presenceInText);

            if(presenceInText){
                int index = usersText.IndexOf(partOftext);
                Console.WriteLine(index);

            }
            Console.ReadLine();


        }
    }
}
