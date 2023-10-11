using System;
using Newtonsoft.Json;
using HauNguyen.Utils;

namespace usepackage
{
  class Program
  {

    //dotnet add /C#/usepackage/usepackage.csproj reference /C#/Utils/Utils.csproj
    class Product
    {
      public string Name { get; set; }
      public DateTime Expiry { get; set; }
      public string[] Sizes { get; set; }

    }

    static void Main(string[] args)
    {
      double a = 45123123123;
      var kq = ConverMoneyToText.NumberToText(a);
      Console.WriteLine(kq);
      ConverMoneyToText.Hello();





      // Product product = new Product();
      // product.Name = "Apple";
      // product.Expiry = new DateTime(2008, 12, 28);
      // product.Sizes = new string[] { "Small" };

      // string json = JsonConvert.SerializeObject(product);
      // Console.WriteLine(json);
      // {
      //   "Name": "Apple",
      //   "Expiry": "2008-12-28T00:00:00",
      //   "Sizes": [
      //     "Small"
      //   ]
      // }
    }
  }
}