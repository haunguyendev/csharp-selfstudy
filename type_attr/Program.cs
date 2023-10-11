using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace type_attr
{
  class Program
  {
    // type -> class, struct,/... int, bool,..
    //Attribute
    // Reclection: thong tin kieu du lieu, thoi diem thuc thi
    // AttributeName

    /*
    Mota 
      - thongtinchitiet
    */
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)] //Mota duoc sua dung o dau (class, property, method,....)

    class MotaAttribute : Attribute
    {
      public string ThongTinChiTiet { get; set; }
      public MotaAttribute(string _ThongTinChiTiet)
      {
        ThongTinChiTiet = _ThongTinChiTiet;
      }
    }


    class User
    {
      [Required(ErrorMessage = "Name is required")]
      [StringLength(50, MinimumLength = 3, ErrorMessage = "Ten phai tu 3 den 100 ki tu")]


      public string Name { get; set; }
      [Range(18, 80, ErrorMessage = "Ten phai tu 3 den 100 ki tu")]
      public int Age { get; set; }

      [Phone]
      public string PhoneNumber { get; set; }


      [EmailAddress(ErrorMessage = "Email is wrong structure")]
      public string Email { get; set; }



      public void PrintInfo() => Console.WriteLine(Name);

    }
    static void Main(string[] args)
    {
      User user = new User()
      {
        Name = "xa",
        Age = 10,
        PhoneNumber = "12312414124",
        Email = "Hauntse170203@gmail.com"
      };


      ValidationContext context = new ValidationContext(user);

      var result = new List<ValidationResult>();
      bool kq = Validator.TryValidateObject(user, context, result, true);
      if (kq == false)
      {
        result.ToList().ForEach((er) =>
        {
          Console.WriteLine(er.MemberNames.First());
          Console.WriteLine(er.ErrorMessage);

        });
      }



    }


  }
}











