using System;
using System.Security.Authentication.ExtendedProtection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
namespace dependency_injection
{

  interface IClassB
  {
    public void ActionB();
  }
  interface IClassC
  {
    public void ActionC();
  }

  class ClassC : IClassC
  {
    public ClassC() => Console.WriteLine("ClassC is created");
    public void ActionC() => Console.WriteLine("Action in ClassC");
  }
  class ClassC1 : IClassC
  {
    public ClassC1() => Console.WriteLine("ClassC1 is created");
    public void ActionC() => Console.WriteLine("Action in ClassC1");
  }

  class ClassB : IClassB
  {
    IClassC c_dependency;
    public ClassB(IClassC classc)
    {
      c_dependency = classc;
      Console.WriteLine("ClassB is created");
    }
    public void ActionB()
    {
      Console.WriteLine("Action in ClassB");
      c_dependency.ActionC();
    }
  }
  class ClassB2 : IClassB
  {
    IClassC c_dependency;
    string message;
    public ClassB2(IClassC classc, string mgs)
    {
      c_dependency = classc;
      message = mgs;
      Console.WriteLine("ClassB2 is created");
    }
    public void ActionB()
    {
      Console.WriteLine(message);
      c_dependency.ActionC();
    }
  }


  class ClassA
  {
    IClassB b_dependency;
    public ClassA(IClassB classb)
    {
      b_dependency = classb;
      Console.WriteLine("ClassA is created");
    }
    public void ActionA()
    {
      Console.WriteLine("Action in ClassA");
      b_dependency.ActionB();
    }
  }

  class Horn
  {
    int level = 0;
    public Horn(int level) => this.level = level;
    public void Beep() => Console.WriteLine("Beep-Beep-Beep");
  }


  class Car
  {
    public Horn horn { get; set; }
    // Inject bang phuong thuc khoi tao
    public Car(Horn _horn) => horn = _horn;
    public void Beep()
    {

      horn.Beep();

    }
  }

  // dependency 
  // Dependency injection
  // 

  class Program
  {


    public static ClassB2 CreateB2Factory(IServiceProvider serviceprovider)
    {
      var service_c = serviceprovider.GetService<IClassC>();
      var sv = new ClassB2(service_c, "Thực hiện trong ClassB2");
      return sv;
    }

    public class MyserviceOptions
    {
      public string data1 { get; set; }
      public int data2 { get; set; }


    }

    public class MyService
    {
      public string data1 { get; set; }
      public int data2 { get; set; }
      public MyService(IOptions<MyserviceOptions> options)
      {
        var _options = options.Value;
        data1 = _options.data1;
        data2 = _options.data2;

      }

      public void PrintData() => Console.WriteLine($"{data1} / {data2}");
    }
    static void Main(string[] args)
    {
      ConfigurationRoot configurationRoot;
      ConfigurationBuilder configbuilder = new ConfigurationBuilder();
      configbuilder.SetBasePath(Directory.GetCurrentDirectory());
      configbuilder.AddJsonFile("cauhinh.json");

      configurationRoot = (ConfigurationRoot)configbuilder.Build();

      var sectionMyServiceOptions = configurationRoot.GetSection("MyServiceOptions");

      var services = new ServiceCollection();
      services.AddSingleton<MyService>();
      services.Configure<MyserviceOptions>(sectionMyServiceOptions);

      var provider = services.BuildServiceProvider();
      var myservice = provider.GetService<MyService>();
      myservice.PrintData();










      //       var services = new ServiceCollection();
      //       services.AddSingleton<MyService>();

      //       services.Configure<MyserviceOptions>(
      // (options) =>
      // {
      //   options.data1 = "xin chao cac ban";
      //   options.data2 = 2021;
      // }

      //       );

      //       var provider = services.BuildServiceProvider();
      //       var myservice = provider.GetService<MyService>();

      //       myservice.PrintData();













    }
  }
}