using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

namespace cs30
{
  public class Product
  {
    public int ID { set; get; }
    public string Name { set; get; }         // tên
    public double Price { set; get; }        // giá
    public string[] Colors { set; get; }     // các màu sắc
    public int Brand { set; get; }           // ID Nhãn hiệu, hãng
    public Product(int id, string name, double price, string[] colors, int brand)
    {
      ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
    }
    // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
    override public string ToString()
       => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

  }
  public class Brand
  {
    public string Name { set; get; }
    public int ID { set; get; }
  }
  class Program
  {


    static void Main(string[] args)
    {
      var brands = new List<Brand>() {
    new Brand{ID = 1, Name = "Công ty AAA"},
    new Brand{ID = 2, Name = "Công ty BBB"},
    new Brand{ID = 4, Name = "Công ty CCC"}
};
      var products = new List<Product>()
{
    new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3)
};

      int[] numbers = { 1, 2, 4, 6, 4, 2, 8, 9 };
      /*
      1) Xac dinh nguon: from tenphantu in IEnumrables
      .... join,where, oderby,let tenbien=??
      2) Lay du lieu: select, group by..

      //Doi tuong
      //Gia
      //Cac san pham
      // So luong


      */
      var qr = from product in products
               join brand in brands on product.Brand equals brand.ID
               select new
               {
                 ten = product.Name,
                 gia = product.Price,
                 thuonghieu = brand.Name
               };

      qr.ToList().ForEach(o =>
      {
        Console.WriteLine($"{o.ten,10} {o.thuonghieu,15} {o.gia,5}");
      });



      // var query = from p in products
      //             select new
      //             {
      //               Ten = p.Name,
      //               Gia=p.Price,
      //               Abc="Hau dep trai"

      //             };

      // query.ToList().ForEach(name => Console.WriteLine(name));

      //Select
      //Where
      // SelectMany
      //Min , Max, Sum, Average.
      //Join
      //GroupJoin
      //Take 
      //Skip
      //OrderBy (tang dan) / OderbyDesc
      // Reverse
      //GroupBy
      //Distinct
      // Single SingleOrDefault
      //Any
      //All
      //Count 
      // In ra ten san pham, ten thuong hieu, co gia (300 -400)
      // gia giam dan






      // var kq = products.Join(brands, p => p.Brand, b => b.ID, (p, b) =>
      // {
      //   return new
      //   {
      //     Ten = p.Name,
      //     ThuongHieu = b.Name
      //   };

      // });

      // var kq = products.SelectMany(
      //   (p) =>
      //   {
      //     return p.Colors;

      //   }
      // );

      // foreach (var gr in kq)
      // {

      //   Console.WriteLine(gr.ThuongHieu);
      //   foreach (var p in gr.Cacsanpham)
      //   {
      //     Console.WriteLine(p);
      //   }
      // }




    }
  }
}