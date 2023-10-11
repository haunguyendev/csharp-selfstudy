using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HauNee.Racer
{
    internal class Motor : DeadRacer
    {
        public string Name { get; set; }
        public double Volumn { get; set; }
        public string PlateNumber { get; set; }

        // 
        public double Run()=> new Random().NextDouble()*120;// expression bodied. Chỉ dùng khi hàm, property có 1 dòng code!!!

        public double RunToDeath() => Run();
       



        // Không nhầm laanx với lamda expression

        //Random random= new Random();// tạo ra máy sinh số ngẫu nhiên
        //// giống máy ném trái banh ngẫu nhiên cho
        //// việc luyện tập phản xạ
        //// Máy-ngẫu nhiên có hành động thảy ra ngẫu nhiên
        //// con số, trái banh, tọa độ....
        //double speed = random.NextDouble()*120; // con số ngãu nhiên ... <12-

        //return speed;





    }
}
