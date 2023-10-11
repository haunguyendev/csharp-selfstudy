using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Hau.Geometric.Shape.V2
{
    internal class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area => Width * Height;//expression body

        public Rectangle(string name, string description, double width, double height) : base(name, description)
        {
            Width = width;
            Height = height;
        }// base(,,) chính là gọi constructor của class cha
        // new Con bản chất bên trong là phải new cha, Có cha rồi mới làm bệ đỡ cho con
        // bệ dỡ : base

    }
    //Vuông là hcn và là hh, nên có 2 cách kế thừa
    //Vuông: shape phải code lại tính S
    // Vuông: rectangle, không cần code lại S
    class Square: Rectangle
    {
        public double Edge { get; set; }
        public Square(string name, string description, double edge) : base(name, description, edge, edge)
            
        {
            Edge = edge;
        }

        // tồn tại 1 điều thú bị: 
        // nếu khai báo
        //Square s= new Square (5.0,"Hv","..")
        //s. chấm sẽ xổ ra cá thứ đuo0wjc thừa kế từ cha rectangle và ông shape có vẻ rằng s. ra Width và Hieght == nhau, bình thường
        // To do: nếu ta set width=10 chẳng hạn, thì length hình như vẫn là 5
        // Suy nghĩ thêm xem sao ??


       

}
