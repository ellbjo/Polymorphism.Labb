using System;

namespace Polymorphism.Labb                                         //Ellinor Vonck labb 7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Default rectangle as well as one custom
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(10,11);

            //Default square as well as one custom
            Square s1 = new Square();
            Square s2 = new Square(6);

            //Default circle as well as one custom 
            Circle c1 = new Circle();
            Circle c2 = new Circle(5);

            //Default ellipse as well as one custom
            Ellipse e1 = new Ellipse();
            Ellipse e2 = new Ellipse(5,8);

            //Default parallellogram as well as one custom
            Parallellogram p1 = new Parallellogram();
            Parallellogram p2 = new Parallellogram(4,9,55);


            //Prints the areas of the objects into the console as well as the angle of the parallellogram
            Console.WriteLine("Circle area: " + c1.Area());
            Console.WriteLine("Circle area: " + c2.Area());

            Console.WriteLine("Square area: " + s1.Area());
            Console.WriteLine("Square area: " + s2.Area());

            Console.WriteLine("Rectangle area: " + r1.Area());
            Console.WriteLine("Rectangle area: " + r2.Area());

            Console.WriteLine("Ellipse area: " + e1.Area());
            Console.WriteLine("Ellipse area: " + e2.Area());

            Console.WriteLine("Parallellogram area: " + p1.Area() +  "\nAngle: " + p1.Angle + " degrees");
            Console.WriteLine("Parallellogram area: " + p2.Area() + "\nAngle: " + p2.Angle + " degrees");




        }
    }
}
