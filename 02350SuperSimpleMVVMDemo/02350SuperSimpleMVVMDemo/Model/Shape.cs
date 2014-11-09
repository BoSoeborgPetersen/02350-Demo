using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350SuperSimpleMVVMDemo.Model
{
    // The Shape class descripes a shape with a position (X and Y), and a size (Width and Height).
    public class Shape
    {
        // Properties.
        // For a description of Auto-Implemented Properties ("{ get; set; }") see the Line class.
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        // The CenterX and CenterY derived properties are used by the Line class, 
        //  so it can be drawn from the center of one Shape to the center of another Shape.
        public int CenterX { get { return X + Width / 2; } }
        // This corresponds to the following in Java (can also be done like this in .NET):

        // public int getCenterX(){
        //   return X + Width / 2;
        // }

        public int CenterY { get { return Y + Height / 2; } }
        // This corresponds to the following in Java (can also be done like this in .NET):

        // public int getCenterY(){
        //   return Y + Height / 2;
        // }
        
        // The constructor is in this case used to set the default values for the properties.
        public Shape()
        {
            X = Y = 200;
            // The "X = Y = value" syntax corresponds to the following:
            // X = 200;
            // Y = 200;
            Width = Height = 100;
            // The "Width = Height = value" syntax corresponds to the following:
            // Width = 200;
            // Height = 200;
        }
    }
}
