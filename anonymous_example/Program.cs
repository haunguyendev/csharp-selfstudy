using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace anonymous_example
{
    class Program
    {
      // anonymous - kieu du lieu vo danh
      // Object - thuoc tinh - chi doc
      // new {thuoc tinh = gia tri, thuoctinh2 = giatri2}
      class Student{
        public string Name { get; set; }
        public void Hello() => Console.WriteLine(Name);


      }


      static void PrintInfo(dynamic obj)
      {
        obj.Name="adfdsafasd";
        obj.Hello();

      }
        static void Main(string[] args)
        {
          Student abc=new Student();
          PrintInfo(abc);

        }
         
}
}

