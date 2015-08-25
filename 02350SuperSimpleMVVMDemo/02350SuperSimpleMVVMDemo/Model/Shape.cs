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
        // The "{ get; set; }" syntax describes that a private field 
        //  and default getter setter methods should be generated.
        // This is called Auto-Implemented Properties (http://msdn.microsoft.com/en-us/library/bb384054.aspx).
        public int X { get; set; } = 200;
        // This corresponds to the following in Java (can also be done like this in .NET):

        // private int x = 200;
        // 
        // public int getX(){
        //   return x;
        // }
        //
        // public void setX(int value){
        //   x = value;
        // }

        public int Y { get; set; } = 200;
        // This corresponds to the following in Java (can also be done like this in .NET):

        // private int y;
        // 
        // public int getY(){
        //   return y;
        // }
        //
        // public void setY(int value){
        //   y = value;
        // }

        public int Width { get; set; } = 100;
        // This corresponds to the following in Java (can also be done like this in .NET):

        // private int width;
        // 
        // public int getWidth(){
        //   return width;
        // }
        //
        // public void setWidth(int value){
        //   width = value;
        // }

        public int Height { get; set; } = 100;
        // This corresponds to the following in Java (can also be done like this in .NET):

        // private int height;
        // 
        // public int getHeight(){
        //   return height;
        // }
        //
        // public void setHeight(int value){
        //   height = value;
        // }

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
    }
}
