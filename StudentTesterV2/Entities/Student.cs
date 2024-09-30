using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV2.Entities
{
    public class Student
    {
        private String _id;
        private String _name;
        private double _gpa;
        private int _password;

        //1 Class có vô số CST ( ConStructor) tùy theo cách mình fill data
        //Điều gì xảy ra nếu k tạo CST => RUNTIME sẽ tạo cho bạn 1 CST Default/Empty CST
        //Khi sài CST Default, Thông tin đổ thế nào
        //Ta vẫn New đc 1 Object, nhưng info bỏ trống, default
        //CST Default chỉ để New Object
        //Tuy nhiên ta có thể chủ động tạo sẵn 1 CST DEfault ( EXPLICIT EMPTY CST - Tường mình rõ ràng)
        //Ngầm tạo giúp mình gọi là IMPLICIT EMPTY CST - Ko Tường Minh
        //Tạo siêu nhanh CTOR TAB
        public Student() //explicit empty cst
        {
            
        }
        //Tạo các CST Empty và các CST khác
        //CTRL .
        public Student(string id, string name, double gpa, int password)
        {
            _id = id;
            _name = name;
            _gpa = gpa;
            _password = password;
        }
        public Student(string id, string name)
        {
            _id = id;
            _name = name;
        }
        //Có bao nhiêu CST bấy nhiêu cách New Object()
        //Nếu Class đã có sẵn 1 CST nào đó thì Run Time k tạo giúp Empty CST nữa, trừ phi bạn chủ động tạo Explicit
        //Mục tiêu cuối là class cần có ít nhất 1 CST

        //Đúc xong thì có object ta sẽ xem Get() sửa SET() tất cả FlexProfile()
        public void FlexProfile() => Console.WriteLine($"{_id} | {_name} |  {_password} | {_gpa}");

        public override string? ToString() => $"{_id} | {_name} |  {_password} | {_gpa}";
            //return base.ToString();
        
        //GET và SET: Thay đổi info của Object, lấy từng miếng info của object
        //ToString() Flex() lấy hết
        //Lý Thuyết: Có N Fields thì có N x 2 hàm Get() Set()
        public String GetId() {  return _id; }
        public String GetName() => _name; 
        public double GetGpa() => _gpa;
        public int GetPassword() => _password;
        
        //SET
        //MỌI hàm SET luôn cần 1 "Value đưa vào". Hàm dưới đưa ID
        public void SetId(String id) { _id = id; }
        public void SetName(String name) { _name = name; }
        public void SetGpa(double gpa) { _gpa = gpa; }
        public void SetPassword(int password) { _password = password; }

        //Đoạn Code GET/SET viết theo style này rất nhàm chán, quen thuộc, nhưng vẫn phải làm, vì nó giúp object có tương tác: cung cấp info, tiếp nhận info
        //bắt buộc phải làm, lặp đi lặp lại và nhàm chán
        //Người ta gọi là BOILER PLATE

        //C# sẽ giúp style mới ( Java chưa có) tránh code Boiler Plate

        //1 Biến bất kì
        int password = 2004;

        //Ta muốn get Value của nó, tên biến là đủ
        //xài tên biến là Get(), Get() là láy info

        //Bản thân 1 biến đã mang 2 ý nghĩa get() và set()
    }
}
