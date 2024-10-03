using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTesterV4.Entities
{
    public class Student
    {
        private String _id;
        private String _name;
        private int _yob;
        private double _gpa;

        public Student()
        {
            
        }

        public Student(string id, string name, int yob, double gpa)
        {
            _id = id;
            _name = name;
            _yob = yob;
            _gpa = gpa;
        }
        public String Id
        {
            get => _id; set => _id = value;
        }
        //Lỡ quên mà k gợi ý
        //PROPFULL  tab twice 

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //Sau khi cos prop , thì ta làm tiếp ToString() và các hàm còn lại
        //New qua cách thức:
        //Truyền thống đủ 2 vế, ăn bớt trái - phải, name-argument, Object initialization

        //Get/Set kiểu mới
        //Theo style biến = (Get) (Set) nhưng vẫn là boiler plate do lặp đi lặp lại


    }
}
