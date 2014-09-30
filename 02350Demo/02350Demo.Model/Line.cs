﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350Demo.Model
{
    // The Line class has a reference to 2 shapes, that it connects.
    public class Line : NotifyBase
    {
        // Properties.
        // Normally Auto-Implemented Properties (http://msdn.microsoft.com/en-us/library/bb384054.aspx) would be used, 
        //  but in this case additional work has to be done when the property is changed, 
        //  which is to raise an INotifyPropertyChanged event that notifies the View (GUI) that this model property has changed, 
        //  so the graphical representation can be updated.
        private Shape from;
        public Shape From { get { return from; } set { from = value; NotifyPropertyChanged("From"); } }
        // This corresponds to the following in Java:

        // private Shape from;
        // 
        // public Shape From(){
        //   return from;
        // }
        //
        // public void From(Shape value){
        //   from = value;
        //   NotifyPropertyChanged("From");
        // }

        private Shape to;
        public Shape To { get { return to; } set { to = value; NotifyPropertyChanged("To"); } }
        // This corresponds to the following in Java:

        // private Shape To;
        // 
        // public Shape To(){
        //   return To;
        // }
        //
        // public void To(Shape value){
        //   To = value;
        //   NotifyPropertyChanged("To");
        // }
    }
}