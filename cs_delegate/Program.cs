namespace cs_delegate {
//delegate (type type) bien = phuong thuc

public delegate void ShowLog(string massage);
  class Program
  {

static void Info(string s){
  Console.ForegroundColor=ConsoleColor.Green;
  Console.WriteLine(s);
  Console.ResetColor();
}
static void Warning(string s){
  Console.ForegroundColor=ConsoleColor.Red;
  Console.WriteLine(s);
  Console.ResetColor();
}
delegate int KIEU1();
static int Tong(int a, int b) => a+b;
static int Hieu(int a, int b)=>a-b;
    static void Main(string[] args)
    {
  //     // action., func: delegate function
  //   Action action;// delegate void KIEU();
  //   Action<string,int> action1;// delegate void KIEU(string s,int i);
  //   Action<string> action2; // delegate void Kieu(string s);
  //   action2=Warning;
  //   action2 +=Info;
  //   action2?.Invoke("thong bao tu action");

  // Func<int> f1; // delegate int Kieu()
  // Func<string,double,string> f2;// delegate string kieu(string s, doouble d);
  Func<int,int,int> tinhtoan; //delegate int Kieu(int a, int b);  

  int a=5;
  int b=10;
  tinhtoan=Hieu;
  Console.WriteLine($"Tong la {tinhtoan(a,b)}");





    }
  }
}
