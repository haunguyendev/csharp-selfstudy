using System;
using MyLib;
namespace CS_ExtensionMethod
{
  static class Abc
  {
    public static void Print(this string s, ConsoleColor color)
    {
      Console.ForegroundColor = color;
      Console.WriteLine(s);
    }
  }
  class Program
  {


    static void Main(string[] args)
    {
      double a = 2.5;
      Console.WriteLine(a.BinhPhuong());
      Console.WriteLine(a.CanBacHai());
      Console.WriteLine(a.Sin());
      Console.WriteLine(a.Cos());




    }
  }
}