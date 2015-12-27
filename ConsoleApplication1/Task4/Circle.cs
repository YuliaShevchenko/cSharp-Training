using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Circle : Figure
    {

        private int radius;

        public Circle(int x, int y, int radius)
        {

            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void showInConsole()
        {

            Console.WriteLine("It's a circle. " + " Coordinates are: " + "x: " + x + " y: " + y + " Square is: " + square());
            Console.ReadKey();
        }
        public override double square()
        {
            double square = Math.PI * radius * radius;
            int convertedSquare = Convert.ToInt32(square);
            return convertedSquare;
        }

        public override bool Equals(object other)
        {

            if (base.Equals(other))
            {
                if (other is Circle)
                {
                    if (((Circle)other).getRadius() == this.radius)
                    {
                        return true;
                    }
                }
                return false;
            } 


            return false;
        }



        int getRadius()
        {
            return radius;
        }

    }
}
