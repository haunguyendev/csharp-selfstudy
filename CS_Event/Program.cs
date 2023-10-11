using System;
using System.Runtime.InteropServices;
namespace CS_Event
{
  // publisher -> class -> phat su kien
  // subscriber -> class -> nhan su kien

  public delegate void SuKienNhapSo(int x);

  class DuLieuNhap : EventArgs
  {
    public int data { get; set; }
    public DuLieuNhap(int x) => data = x;
  }
  class UserInput
  {
    public event EventHandler sukiennhapso;// delegate void KIEU(object? sender, EventArgs args)
    public void Input()
    {
      do
      {
        Console.WriteLine("Nhap vao so nguyen:");
        string s = Console.ReadLine();
        int i = Int32.Parse(s);
        sukiennhapso?.Invoke(this, new DuLieuNhap(i));
      } while (true);
    }
  }
  class TinhCan
  {
    public void Sub(UserInput input)
    {
      input.sukiennhapso += Can;

    }
    public void Can(object? sender, EventArgs e)
    {
      DuLieuNhap dulieunhap = (DuLieuNhap)e;
      int i = dulieunhap.data;

      Console.WriteLine($"Can bac 2 cua {i} la {Math.Sqrt(i)}");
    }
  }
  class BinhPhuong
  {
    public void Sub(UserInput input)
    {
      input.sukiennhapso += TinhBinhPhuong;

    }
    public void TinhBinhPhuong(object? sender, EventArgs e)
    {
      DuLieuNhap duLieuNhap = (DuLieuNhap)e;
      int i = duLieuNhap.data;

      Console.WriteLine($"Binh phuong cua {i} la {Math.Pow(i, 2)}");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      //publisher phat ra su kien
      UserInput userInput = new UserInput();
      userInput.sukiennhapso += (sender, e) =>
      {
        DuLieuNhap duLieuNhap = (DuLieuNhap)e;

        Console.WriteLine("Ban vua nhap so: " + duLieuNhap.data);
      };


      TinhCan tinhcan = new TinhCan();
      tinhcan.Sub(userInput);

      BinhPhuong tinhBinhPhuong = new BinhPhuong();
      tinhBinhPhuong.Sub(userInput);

      userInput.Input();

    }
  }


}