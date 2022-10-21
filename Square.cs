using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Labb
{
    public class Square : Geometry
    {
        //Properties for the square-object
        public double Height { get; set; }

        //Creates a constructor and sets the default height to 4 if nothing is passed to the constructor
        public Square (double height = 4)
        {
            this.Height = height;
        }

        //Method that calculates the area (overrides the method in the parentclass)
        public override double  Area()
        {
            return Math.Round(Height * Height, 2);
        }
    }
}
