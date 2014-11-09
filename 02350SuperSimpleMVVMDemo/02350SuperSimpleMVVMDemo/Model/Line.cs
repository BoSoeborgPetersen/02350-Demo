using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350SuperSimpleMVVMDemo.Model
{
    // The Line class has a reference to 2 shapes, that it connects.
    public class Line
    {
        // Properties.
        // The "{ get; set; }" syntax describes that a private field 
        //  and default getter setter methods should be generated.
        // This is called Auto-Implemented Properties (http://msdn.microsoft.com/en-us/library/bb384054.aspx).

        public Shape From { get; set; }
        // This corresponds to the following in Java (can also be done like this in .NET):

        // private Shape from;
        // 
        // public Shape getFrom(){
        //   return from;
        // }
        //
        // public void setFrom(Shape value){
        //   from = value;
        // }

        public Shape To { get; set; }
        // This corresponds to the following in Java (can also be done like this in .NET):

        // private Shape to;
        // 
        // public Shape getTo(){
        //   return to;
        // }
        //
        // public void setTo(Shape value){
        //   to = value;
        // }
    }
}
