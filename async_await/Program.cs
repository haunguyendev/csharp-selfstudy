using System.Net.Http.Headers;

namespace async_await
{
  class Program
  {
    static void DoSomeThing(int seconds, string mgs, ConsoleColor color)
    {
      lock (Console.Out)
      {
        Console.ForegroundColor = color;
        Console.WriteLine($"{mgs,10} ... Start ");

      }



      for (int i = 1; i <= seconds; i++)
      {
        lock (Console.Out)
        {
          Console.WriteLine($"{mgs,10} {i,2}");
          Console.ResetColor();
          Thread.Sleep(1000);
        }
      }
      lock (Console.Out)
      {

        Console.ForegroundColor = color;
        Console.WriteLine($"{mgs,10}.... End");
        Console.ResetColor();
      }
    }

    static void Main(string[] args)
    {//Synchronous 
     //Task
      Task t2 = new Task(
        () =>
        {
          DoSomeThing(10, "T2", ConsoleColor.Green);

        }
      );// () =>

      Task t3 = new Task(
        (object ob) =>
        {
          string tentacvu = (string)obj;

        }

      );


      DoSomeThing(6, "T1", ConsoleColor.Magenta);
      DoSomeThing(10, "T2", ConsoleColor.Green);
      DoSomeThing(4, "T3", ConsoleColor.Yellow);
      Console.WriteLine("Hello world!");


    }
  }
}