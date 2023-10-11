namespace cs_lambda{
  /*
  Lambda - anonymous function
  1.
  (tham_so) => bieu thuc;
  2.
  (tham_so) => {
    bieu_thuc;
    return bieu_thuc_tra_ve;
  }
  */ 

  class Program
  {
    static void Main(string[] args)
    {
     
     int[] mang= {2,3,4,1,4,5,6,3,2,45,3,12};
     
     var kq= mang.Where(
      (x)=>{
        return x%4==0;
      }
     );

     foreach(var n in kq){
      Console.WriteLine(n);
     }
      


    }
  }
}