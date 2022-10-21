using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Labb
{
    public class Parallellogram : Geometry
    {
        //Properties of the Parallelogram-object, includes angle
        public double Height { get; set; }
        public double Length { get; set; }
        public double Angle { get; set; }

        //constructor for the parallelogram object, sets default height to 3 and length to 8 if nothing is passed to the constructor
        public Parallellogram(double height = 3, double length = 8, double angle = 70)
        {
            this.Height = height;
            this.Length = length;
            this.Angle = angle;
        }

        //Method that calculates the area (overrides the method in the parentclass)
        public override double Area()
        {
            return Math.Round(Height * Length, 2);
        }
    }
}
