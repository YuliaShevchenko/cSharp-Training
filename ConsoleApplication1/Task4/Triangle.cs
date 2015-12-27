using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Triangle : Figure
    {
        private int side;
        public Triangle(int x, int y, int side)
        {
            
            this.x = x;
            this.y = y;
            this.side = side;
        }
        public override void showInConsole()
        {
            Console.WriteLine("It's a Triangle. " + " Coordinates are: " + "x: " + x + " y: " + y + " Square is: " + square());
            Console.ReadKey();
        }
        public override double square()
        {
            double square = (Math.Sqrt(3) / 4) * side * side;
            int convertedSquare = Convert.ToInt32(square);
            return convertedSquare;
        }

        //public override bool equalsTwoObjects(Figure other)
        //{
        //    if (other is Triangle)
        //    {
        //        Triangle triangle = (Triangle)other;
        //        int xForVerification = triangle.getX();
        //        int yForVerification = triangle.getY();
        //        int sideForVerification = triangle.getSide();

        //        if (xForVerification == x && yForVerification == y && sideForVerification == side)
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
        int getSide()
        {
            return side;
        }

    }
}
