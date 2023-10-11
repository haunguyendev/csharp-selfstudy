using System;
using System.IO.Enumeration;
using System.Text;
namespace file_example
{
  class Program
  {
    class Product
    {
      public int ID { get; set; }
      public double Price { get; set; }
      public string Name { get; set; }

      public void Save(Stream stream)
      {
        // int -> 4byte
        var bytes_id = BitConverter.GetBytes(ID);
        stream.Write(bytes_id, 0, 4);
        //double -> 8byte
        var bytes_price = BitConverter.GetBytes(Price);
        stream.Write(bytes_price, 0, 8);
        var bytes_name = Encoding.UTF8.GetBytes(Name);
        var bytes_leng = BitConverter.GetBytes(bytes_name.Length);
        stream.Write(bytes_leng, 0, 4);
        stream.Write(bytes_name, 0, bytes_name.Length);



      }

      public void Restore(Stream stream)
      {

        var bytes_id = new byte[4];
        stream.Read(bytes_id, 0, 4);
        ID = BitConverter.ToInt32(bytes_id, 0);

        var bytes_price = new byte[8];
        stream.Read(bytes_price, 0, 8);
        Price = BitConverter.ToDouble(bytes_price, 0);

        var bytes_leng = new byte[4];
        stream.Read(bytes_leng, 0, 4);
        int leng = BitConverter.ToInt32(bytes_leng, 0);


        var bytes_name = new byte[leng];
        stream.Read(bytes_name, 0, leng);

        stream.Write(bytes_leng, 0, 4);
        stream.Write(bytes_name, 0, bytes_name.Length);
        Name = Encoding.UTF8.GetString(bytes_name);




      }

    }

    static void Main(string[] args)
    {
      string path = "data.dat";
      using var stream = new FileStream(path: path, FileMode.OpenOrCreate);

      Product product = new Product();
      // {
      //   ID = 10,
      //   Price = 1245,
      //   Name = "San pham Abc"

      // };
      product.Restore(stream);

      Console.WriteLine($"{product.Name}- {product.Price}-{product.ID}");



    }
  }
}