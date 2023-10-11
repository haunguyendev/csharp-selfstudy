using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hau.Geometric.Shape.V2
{
    internal class Disk:Shape
    {
        

        public double Radius { get; set; }
        public Disk(double radius,string name, string description) : base(name, description)
        {
            Radius = radius;
        }
        public override double Area => Math.PI*Math.Pow(Radius,2);

    }
}
