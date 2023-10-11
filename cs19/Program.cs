// See https://aka.ms/new-console-template for more information
namespace cs19{
  // interface
  interface IHinhHoc
  {
    public double TinhChuVi();
    public double TinhDienTich();

  }

  class HinhChuNhat : IHinhHoc{
        public HinhChuNhat(double a, double b)
        {
          this.a=a;
          this.b=b;
        }

        public double a { get; set; }
    public double b { get; set; }

        public double TinhChuVi()
        {
            throw new NotImplementedException();
        }

        public double TinhDienTich()
        {
            throw new NotImplementedException();
        }
    }
  class Program
  {
    static void Main(string[] args){
      

    }
  }
}
