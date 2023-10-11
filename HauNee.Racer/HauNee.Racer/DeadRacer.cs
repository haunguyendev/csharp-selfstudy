using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HauNee.Racer
{
    internal interface DeadRacer
    {// Phàm đã là đưa thủ, thì nhiệm vụ phải đưua
     // ai muốn đưa giarik rgif đứa phải cảm kết đưa.
     // đua thế nào, tùy mỗi đứa, nhưng phải đưa,vì đã tham đưa thế nào
     // Đưa thế nào: bốc đầu, cà chân chống, tung mình ...
     // Mỗi đua thủ tự lo - Implement theo cách của mỗi đứa
     // Đưa hình : đua () , mỗi đứa tự đua() theo cách reieengh!!
     // Hành đua() ở đây sẽ là abstrct, tao nói ý là đua hết hình còn mỗi đứa thế nào


        public double RunToDeath();//Không cần từ khóa abstract
                                   // như bên class abstract, mặc định là vậy
                                   // Tất cả ai tham gia đưa- class "con"
                                   // phải implemetn
     // Một class nào đó (concrete) chỉ có tối đa 1 class cha - kế thừa
     // Nhưng có thể tham gia vào n - interface- clb
     // Mỗi trường chỉ có 1 dòng họ
     // Và có thể tham gia nhiều clb, hội nhóm
     // Java: Motto extends Cha- Nào - f (Implement deadracer)
     


     // c# Moto: cha nào con đó, implement deadraver
     //Motor: Vehicle, DeadRace



    }
}
