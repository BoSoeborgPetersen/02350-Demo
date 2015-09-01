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
        // Regions can be used to make code foldable (minus/plus sign to the left).
        #region Properties

        // The "{ get; set; }" syntax describes that a private field 
        //  and default getter setter methods should be generated.
        //  This is called Auto-Implemented Properties (http://msdn.microsoft.com/en-us/library/bb384054.aspx).
        // Java:
        //  private int x = 200;
        // 
        //  public int getX(){
        //    return x;
        //  }
        //
        //  public void setX(int value){
        //    x = value;
        //  }
        public int X { get; set; } = 200;

        // Java:
        //  private int y = 200;
        // 
        //  public int getY(){
        //    return y;
        //  }
        //
        //  public void setY(int value){
        //    y = value;
        //  }
        public int Y { get; set; } = 200;

        // Java:
        //  private int width = 100;
        // 
        //  public int getWidth(){
        //    return width;
        //  }
        //
        //  public void setWidth(int value){
        //    width = value;
        //  }
        public int Width { get; set; } = 100;

        // Java:
        //  private int height = 100;
        // 
        //  public int getHeight(){
        //    return height;
        //  }
        //
        //  public void setHeight(int value){
        //    height = value;
        //  }
        public int Height { get; set; } = 100;

        #endregion

        #region Derived Properties

        // The CenterX and CenterY derived properties are used by the Line class, 
        //  so it can be drawn from the center of one Shape to the center of another Shape.
        // Java:
        //  public int getCenterX(){
        //    return X + Width / 2;
        //  }
        // This method uses an expression-bodied member (http://www.informit.com/articles/article.aspx?p=2414582) to simplify a method that only returns a value;
        // Old .NET (Before 4.6):
        //  public int CenterX { get { return X + Width / 2; } }
        public int CenterX => X + Width / 2;

        // Java:
        //  public int getCenterY(){
        //    return Y + Height / 2;
        //  }
        // Old .NET (Before 4.6):
        //  public int CenterY { get { return Y + Height / 2; } }
        public int CenterY => Y + Height / 2;

        #endregion
    }
}
