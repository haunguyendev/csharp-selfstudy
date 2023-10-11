using System;
namespace CS_24
{
  class CountNumber
  {
    public static int number = 0;
    public static void Info()
    {
      Console.WriteLine("So lan truy cap: " + number);
    }
    public void Count()
    {
      CountNumber.number++;


    }
  }

  class Student
  {
    public readonly string name = "Nguyen  van a";
  }
  class Vector
  {
    double x;
    double y;

    public Vector(double _x, double _y)
    {
      this.x = _x;
      this.y = _y;

    }
    public void Info()
    {
      Console.WriteLine($"x={x}, y={y}");
    }
    // vector+ vector => vector

    public static Vector operator +(Vector v1, Vector v2)
    {
      return new Vector(v1.x + v2.x, v1.y + v2.y);



    }

  }

  class Program
  {
    static void Main(string[] args)
    {

      Vector v1 = new Vector(1, 2);
      Vector v2 = new Vector(2, 3);

      var v3 = v1 + v2;
      v1.Info();
      v2.Info();
      v3.Info();







    }
  }
}