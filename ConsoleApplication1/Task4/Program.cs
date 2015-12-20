using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 6, 2, 5);
            rectangle.showInConsole();
            Rectangle rectangleToVerify = new Rectangle(5, 6, 2, 5);
            bool verificationOfRectangle = rectangle.equalsTwoObjects(rectangleToVerify);
            Console.WriteLine(verificationOfRectangle);

            //
            Triangle triangle = new Triangle(5, 6, 3);
            triangle.showInConsole();
            Triangle triangleToVerify = new Triangle(5, 6, 2);
            bool verificationOfTriangle = triangle.equalsTwoObjects(triangleToVerify);
            Console.WriteLine(verificationOfTriangle);

            //
            Circle circle = new Circle(5, 6, 2);
            circle.showInConsole();
            Circle circleToVerify = new Circle(5, 6, 2);
            bool verificationOfCircle = circle.equalsTwoObjects(rectangle);
            Console.WriteLine(verificationOfCircle);
            Console.ReadKey();
        }
    }
}
