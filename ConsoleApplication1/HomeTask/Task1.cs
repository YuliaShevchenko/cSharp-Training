using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    class Task1
    {
        public static string method1(string text){
            StringBuilder builder = new StringBuilder();
            char[] chars = text.ToCharArray();
            foreach (char x in chars)
            {
                builder.Append(x).Append(" ");
                
               
            }
            string textWithSpaces = builder.ToString();

            return textWithSpaces;

    }
        public static string method1(int value){
            string returnedText;
            if (value > 5)
            {
               returnedText = "TooBig"; 
            }
            else
            {
                returnedText = "TooSmall"; 
            }
            return returnedText ;
           
    }
    }
}
