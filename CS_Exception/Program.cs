using MyExeption;


namespace CS_Exception
{
  class Program
  {
    static void Register(string name, int age)
    {
      if (string.IsNullOrEmpty(name))
      {
        throw new NameEmptyException();
      }
      if (age < 18 || age > 100)
      {
        throw new AgeException(age);
      }

      Console.WriteLine($"Xin chao {name} ({age}) ");
    }
    static void Main(string[] args)
    {
      try
      {
        Register("hau", 10);
      }
      catch (NameEmptyException e)
      {
        Console.WriteLine(e.Message);
      }
      catch (AgeException e)
      {
        Console.WriteLine(e.Message);
        e.Detail();
      }


    }
  }
}