using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            playwithrectangle();
        }
        static void SortShape()
        {
            //Hãy sắp xếp theo thứ tăng dần của diện tích của 2 tròn, 2 cn
            //Muốn sắp xếp thì phải chung mảng, chung collection!!
            //Mảng: Dành cho những thằng cùng kiểu/cùng data type.
            //Retangle tr = new Dick();// gãy vì khác new
            //Object tr = new Dick;
            //Object cn=new Dick();
            Retangle r1=new Retangle() { Width=5,Height=5,Name="R1 55"};
            Retangle r2=new Retangle() { Width=1,Height=2,Name="R2 12"};
            Dick d1 = new Dick() { Radius = 2, Name="D1 2" };
            Dick d2 = new Dick() { Radius = 2, Name = "D1 1" };

            Shape[] shapes = {r1,r2 ,d1 ,d2 };
            //Khai báo mảng và gán 4 hình vào mảng
            // in mảng trước khi sort
            Console.WriteLine("The arrays before sorting by area");
            foreach(Shape x in shapes)
            {
               Console.WriteLine(x.Name+" | "+x.GetArea());
            }
            // Đa hình: gọi hàm cha, nhưng 2 con hưởng
            // 1 cha có nhiều hành động khác biệt ở con

            Console.WriteLine("The arrays after sorting by area ascending");
            for(int i = 0; i < shapes.Length - 1; i++)
            {
                for(int j = i + 1; j < shapes.Length; i++)
                {
                    if (shapes[i].GetArea() > shapes[j].GetArea())
                    {
                        //[i] > [j] về s, thì đổi chỗ
                        Shape tmp = shapes[i];
                        shapes[i] = shapes[j];
                        shapes[j] = tmp;
                    }
                }
            }
            for(int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine(shapes[i].Name +" | " + shapes[i].GetArea);
            }

        }
        static void PlayWithRectangle()
        {
            // Khai báo, tạo object HCN
            // có 2 cách khai báo: Khai cha new Con
            Retangle r1 = new Retangle();
            Console.WriteLine("Rectangle 1 -> W : " + r1.Width);

            Retangle r2 = new Retangle() { Width = 15, Height = 8, Name = "Rectangle", Description = "" };

            Console.WriteLine("Rectangle 2-> W:" + r2.Width +
                "L" + r2.Height +
                "Area:" + r2.GetArea());

            Shape r3 = new Retangle() { Width = 10, Height = 10 };
            Console.WriteLine("Rectangle 3-> W:" + r3.Width +
                "L" + r3.Height +
                "Area:" + r3.GetArea());

            //Retangle r5 = new Shape();
            //Khai con new cha => Lệ phí đổi ngành 2.350.000
            //ngáo, vietsub: Hình học là hcn
            // Kế thừa chỉ độc 1 chiều "Is' chỉ đọc 1 chiều
            // HV là HCN, là HH
            //HT là hh
            // HH là Hình tròn là sai
            // HH là hcn là sai

        }

    }
}
