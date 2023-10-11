using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dick :Shape
    {
        public double Radius { get; set; }

        public override double GetArea()
            => Math.PI*Math.Pow(Radius, 2);
        //Expression body
        //Chỉ được dùng expression body với hàm, property
        //{
        //    //return Math.PI * Radius*Radius;
        //    return Math.PI*Math.Pow(Radius, 2);

        //}

    }
}
