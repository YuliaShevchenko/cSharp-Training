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

        public override bool equalsTwoObjects(Figure figure)
        {
            if (figure is Circle)
            {
                Circle circle = (Circle)figure;
                int xForVerification = circle.getX();
                int yForVerification = circle.getY();
                int radiusForVerification = circle.getRadius();

                if (xForVerification == x && yForVerification == y && radiusForVerification == radius)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        int getX()
        {
            return x;
        }
        int getY()
        {
            return y;
        }
        int getRadius()
        {
            return radius;
        }
       
    }
}
