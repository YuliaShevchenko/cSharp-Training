using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   abstract class Figure : Drawing
    {
      
      protected int x;
      protected int y;
       

       public abstract void showInConsole();
       

       public abstract bool equalsTwoObjects(Figure figure);


       public abstract double square();
      

       
       
    }
}
