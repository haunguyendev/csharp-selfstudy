using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Shape
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double GetArea();
    }
    class Retangle:Shape { 
        public double Width { get; set; }
        public double Height { get; set; }
        //Java @ overide
        public override double GetArea() => Width * Height;


        

    }

}
