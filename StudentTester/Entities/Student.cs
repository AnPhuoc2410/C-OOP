using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//~             java.util
namespace StudentTester.Entities
{
    public class Student

    {
        private String _id; //ID:
        private String _name; //Name
        private int _yob; //YOB:
        private double _gpa; //GPA

        //Class như 1 cái khuôn, form, biểu mẫu để điền vô, Blue-print (dàn khung, bản phác thảo, bản thiết kế)
        //Là tên gọi chung cho 1 nhóm Object chia sẻ chung nhều đặc tính và hành vi( Field, behavior/method)
        //Để có 1 object, để có 1 hồ sơ sv nhập học, ta phải điền vào Form ở trên. Ta phải photo 1 form trắng - new (Clone, photo)
        //Sau đó ta fill info, đổ info vào (tham số hàm)
        //Fill vào để tạo Object - Contruct/ Contructor(tham số vật liệu đưa vào)
        // new          Student         (...) => clone form
        //xin vùng ram  nhận giá trị    vật liệu đưa vào

        //Object đặt tên biến ? Student tèo = , Student tí = 

        //Phần Code còn lại y chang Java
        //Contructor để đúc Object
        //Các hàm get() set() ToString() 

        //phễu
        public Student(String id, String name, int yob, double gpa)
        {
            this._id = id; //k cần sài this. để tránh nhầm lẫn trong biến đầu vào và đặc tính Object
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        public void FlexProfile() => Console.WriteLine($"ID: {_id}" + $" Name: {_name}" + $" YoB: {_yob}" + $" Gpa: {_gpa}");
        
        //Object đc tạo ra, tức là đã đổ info vào
        //giống như bạn vào ngân hàng, làm phiếu rút tiền, điền phiếu rút tiền, gọi là get() info
        //Tôi biết bạn có tên, nhưng tên đang private
        //Getname() -> return name
        public String GetName() => _name;

        public int GetAge() => 2024 - _yob;
        //HARDED-CODE trong code có những giá trị cố định, con số cố định
        //Gọi class lấy (ngày giờ hệ thống - _yob)

        public double GetGpa() => _gpa;

        //Cần chuẩn bị 1 cái hình
        //Nhấn nút, thay thế khung hình = hình mớ chuẩn bị
        //Đổi nền (hình mới) Set, Setting, Setter
        //{
        // Hình-Cũ = Hình-Mới;
        //}
        //Setting k tạo ra object mới mà chỉ là tinh chỉnh object cũ đang có
        
        //Một SV có GPA, kì này có điểm mới, phải được cập nhật
        public void SetGpa(double gpa) //convert thành expression body
        {
            _gpa = gpa;
        }
        public void SetName(String name) => _name = name;
        public void SetYob(int yob) => _yob = yob;
        //Hàm Set() giống và khác phễu contructor như thế nào??
        //Giống: đều đổ info vào vùng ram, vùng new
        //Khác: Phễu COnstructor mỗi lần gọi là 1 lần xin ram cho object, tạo mới object
        //      Hàm Set() mỗi làn gọi, là đổ vào vùng ram cũ đã NEW từ trước, chỉnh sửa vùng ram đã có, k tạo mới vùng ram Object
        //THẰNG NÀO CŨNG CÓ THỂ ĐC GỌI NHIỀU LẦN
        //Set() mà gọi giống mình xăm hình, nhuộm tóc

        //Hàm SET() là của từng object mỗi người có như cầu độ khác nhau -> Khi gọi đi kèm biến object
        //


    }
}
