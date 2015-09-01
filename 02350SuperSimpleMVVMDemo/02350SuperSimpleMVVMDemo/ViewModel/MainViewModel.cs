using _02350SuperSimpleMVVMDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350SuperSimpleMVVMDemo.ViewModel
{
    // Use the <summary>...</summary> syntax to create XML Comments, used by Intellisence (Java: Content Assist), 
    // and to generate many types of documentation.
    /// <summary>
    /// This ViewModel is bound to the MainWindow View.
    /// </summary>
    public class MainViewModel
    {
        // Regions can be used to make code foldable (minus/plus sign to the left).
        #region Properties

        // The purpose of using an ObservableCollection instead of a List is that it implements the INotifyCollectionChanged interface, 
        //  which is different from the INotifyPropertyChanged interface.
        // By implementing the INotifyCollectionChanged interface, an event is thrown whenever an element is added or removed from the collection.
        // The INotifyCollectionChanged event is then used by the View, 
        //  which update the graphical representation to show the elements that are now in the collection.
        // Also the collection is generic ("<Type>"), which means that it can be defined to hold all kinds of objects (and primitives), 
        //  but at runtime it is optimized for the specific type and can only hold that type.
        public ObservableCollection<Shape> Shapes { get; set; }
        public ObservableCollection<Line> Lines { get; set; }

        #endregion

        #region Constructor

        // This is where you can change the properties of the Shapes and Lines to move them in the View (Window), to play a little with this very simple demo.
        public MainViewModel()
        {
            // Here the list of Shapes is filled with 2 Nodes. 
            // The "new Type() { prop1 = value1, prop2 = value }" syntax is called an Object Initializer, which creates an object and sets its values.
            // This is equivalent to the following:
            //  Shape shape1 = new Shape();
            //  shape1.X = 30;
            //  shape1.Y = 40;
            //  shape1.Width = 80;
            //  shape1.Height = 80;
            // Also a constructor could be created for the Shape class that takes the parameters (X, Y, Width and Height), 
            //  and the following could be done:
            //   new Shape(30, 40, 80, 80);
            Shapes = new ObservableCollection<Shape>() { 
                new Shape() { X = 30, Y = 40, Width = 80, Height = 80 }, 
                new Shape() { X = 140, Y = 230, Width = 100, Height = 100 } 
            };
            // Here the list of Lines is filled with 1 Line that connects the 2 Shapes in the Shapes collection.
            // The Shapes[0] syntax (which is normal for arrays), can be used with many types of collections in .NET.
            Lines = new ObservableCollection<Line>() { 
                new Line() { From = Shapes[0], To = Shapes[1] } 
            };
        }

        #endregion
    }
}
