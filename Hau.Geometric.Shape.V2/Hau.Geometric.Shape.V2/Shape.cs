using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hau.Geometric.Shape.V2
{
    internal abstract class Shape
    {
        public string Name { get; set; } 
        public string Description { get; set; }

        public Shape(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public abstract double Area { get; }

        // diện tích chỉ có thể là getArea() như java
        // get() mấy, return mấy, ai biết , vấn đề là hình gì
        // do Area là abstract

    }
}
