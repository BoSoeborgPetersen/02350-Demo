﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02350AdvancedDemo.Model
{
    [ImplementPropertyChanged]
    public class Line
    {
        public Shape From { get; set; }
        
        public Shape To { get; set; }
    }
}
