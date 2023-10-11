// See https://aka.ms/new-console-template for more information
using System;
namespace generic_example
{
  class Program
  {
    class Product<A>
    {
      A ID;

      public void setID(A ID){
        this.ID = ID;

      }
      public void PrintInf()
      {
        Console.WriteLine($"ID = {this.ID}");
      }
    }
    static void Main(string[] args)
    {
     List<int> list1=new List<int>();
     List<string> list2=new List<string>();
     Stack<int> stack1=new Stack<int>();
     Queue<int> queue1=new Queue<int>();


    }
  }
}
