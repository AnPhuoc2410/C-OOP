using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV3.Entities
{
    public class Student
    {
        private String _id;
        private String _name;
        private int _yob;
        private double _gpa;

        public Student() { }

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }

        //GET và SET
        //Id là 1 thứ lai giữa biến và hàm, bao get/set lại
        //Nhưng sài Get/Set qua Style gắn giá trị cho biến
        //Chơi biến nhưng là gọi hàm => Tự nhiên trong viết
        //Thay đổi giá trị biến là Set, gọi tên biến là Get
        //Property Of A CLASS

        public String Id 
        { 
            get 
            { 
                return _id; //BACKING FIELD
            } 
            set 
            { 
                _id = value; //
            } 
        }
            // .Id sẽ là GetId();
            // .Id = "SE12"; là SetId("SE12");
        //GetName SetName truyền thống
        public String Name
        {
            get => _name;
            set => _name = value;
                  }
        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }
        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        public override string? ToString() => $"Student: {Id} | {Name} | {Gpa} | {Yob}";
    }

}
//Xài PROPERTY nghĩa là ta chế ra 1 biến - lai với hàm, bao Get() Set() truyền thống, 2 hàm này thao tac trên _FIELD để lưu trữ/thao tác các attribute của 1 class
//_FIELD lúc này đc gọi là hậu phương của biến lai Id, Name, Yob, Gpa,..
//Đằng sau PROPERTY là biến _FIELD lo cho việc GET() Set() lúc này _FIELD ĐC GỌI LÀ ==> BACKING FIELD
// _id, _name, _yob, _gpa,...: BACKING FIELD
