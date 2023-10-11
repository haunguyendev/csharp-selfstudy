using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace ListExample
{
  class Program
  {
    class Product
    {
      public String Name { get; set; }
      public double Price { get; set; }
      public int ID { get; set; }
      public string Origin { get; set; }


    }
    //List
    //SortedList

    static void Main(string[] args)
    {
      Queue<string> cachoso = new Queue<string>();
      cachoso.Enqueue("Ho so 1");
      cachoso.Enqueue("Ho so 2");

      cachoso.Enqueue("Ho so 3");
      var hoso = cachoso.Dequeue();
      Console.WriteLine($"Xy ly ho so: {hoso} - {cachoso.Count()}");



    }
  }
}