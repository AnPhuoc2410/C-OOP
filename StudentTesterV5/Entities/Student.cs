using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV5.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //Kĩ thuật Code kiểu này là kĩ thuật giấu BACKING FILE
        //Vì đằng nào backing file cũng là ẩn sau các biến PROPERTY này
        //Nên RUNTIME tự sinh ra _Backing FIle để đỡ phải khai báo từng biến private, những đoạn code nhàm chán
        //AUTO - GENERATED PROPERTY

        //Nếu quên cú pháp auto - generated property
        //Gõ prop tab twice
        //public int MyProperty { get; set; }

    }
}
//KHI NÀO SÀI KĨ THUẬT PROPERTY: FULL PROPERTY ( BACKING FILED do mình tạo) VÀ AUTO-IMPLEMENTED PROPERTY ( GIẤU BACKING FILED)
//Cho AUTO-IMPLEMENTED PROPERTY
//Thường ta hay sài với class mà nó sẽ map Data xuống table
//Table là nơi Set và Get Data, xử lí để ở câu query, trong ram ở class khác
//K ai cấm bạn sài property dạng Full hoặc Auto ở các class khác
