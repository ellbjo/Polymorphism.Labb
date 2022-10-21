using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Labb
{
    public class Rectangle : Geometry
    {
        //Properties of the Rectangle-object
        public double Height { get; set;}
        public double Length { get; set; }

        //constructor for the Rectangle object, sets default height to 4 and length to 5 if nothing is passed to the constructor
        public Rectangle(double height = 4, double length = 5)
        {
            this.Height = height;
            this.Length = length;
        }

        //Method that calculates the area (overrides the method in the parentclass)
        public override double Area()
        {
            return Math.Round(Height * Length,2);
        }

    }
}
