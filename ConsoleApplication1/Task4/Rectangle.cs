using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Rectangle : Figure
    {
        private int sideA;
        private int sideB;

        public Rectangle(int x, int y, int sideA, int sideB)
        {
            
            this.x = x;
            this.y = y;
            this.sideA = sideA;
            this.sideB = sideB;
            
        }

        public override void showInConsole()
        {
            Console.WriteLine("It's a Rectangle. " + " Coordinates are: " + "x: " + x + " y: " + y + " Square is: " + square());
            Console.ReadKey();
        }
        public override double square()
        {
            double square = sideA * sideB;
            int convertedSquare = Convert.ToInt32(square);
            return convertedSquare;
        }

        //public override bool equalsTwoObjects(Figure other)
        //{
        //    if (other is Rectangle)
        //    {
        //        Rectangle rectangle = (Rectangle)other;
        //        int xForVerification = rectangle.getX();
        //        int yForVerification = rectangle.getY();
        //        int sideAForVerification = rectangle.getSideA();
        //        int sideBForVerification = rectangle.getSideB();

        //        if (xForVerification == x && yForVerification == y && sideAForVerification == sideA && sideBForVerification == sideB)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        int getX()
        {
            return x;
        }
        int getY()
        {
            return y;
        }
        int getSideA()
        {
            return sideA;
        }
        int getSideB()
        {
            return sideB;
        }

    }
}
