namespace HauNee.Racer
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Motor ex1 = new Motor()
            {
                PlateNumber = "53F1 049,53",
                Name = "Exxciter 2019",
                
            };
            Console.WriteLine("Exciter run:" +ex1.Run());
            Console.WriteLine("Exciter speed as a racer: "+ex1.Run());

            DeadRacer win = new Motor();
            Console.WriteLine(win.RunToDeath());

            Console.WriteLine(((Motor)win).Run());


        }
    }
}