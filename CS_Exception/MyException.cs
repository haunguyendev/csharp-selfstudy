using System;
namespace MyExeption
{
  public class NameEmptyException : Exception
  {
    public NameEmptyException() : base("Ten phai khac rong")
    {

    }

  }
  public class AgeException : Exception
  {
    public int age { set; get; }
    public AgeException(int _age) : base("Toi khong phu hop")
    {
      age = _age;

    }
    public void Detail()
    {
      Console.WriteLine($"Tuoi ={age}, khong nam trong khoang [18-100]");
    }

  }
}