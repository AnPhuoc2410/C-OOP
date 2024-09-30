using StudentTesterV3.Entities;

namespace StudentTesterV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new(gpa: 8.3, yob:2004,name:"PH", id:"SE11111");
            var student2 = new Student();//TYPE INFERENCE
            Console.WriteLine(student.Id);
            student.Id = "SE206789";
            Console.WriteLine(student.Id);
            Console.WriteLine("student: " + student);//GOi ToString
            Console.WriteLine("Student name: " + student.Name);
            Console.WriteLine("Student yob: " + student.Yob);

           //Sử dụng Get Set ngay khi New
           var Phuoc = new Student();
            Console.WriteLine("Phuoc info at first: {0}" , Phuoc);
            //Điền Info qua con đường Set()
            //Cách C#
            Phuoc.Id = "Kamen";
            Phuoc.Yob = 2009;
            Phuoc.Gpa = 8.3;
            Phuoc.Name = "Double";
            //Get() Set() tự nhiên như đang sài biến, biến bản chất bao hàm sẵn ý nghĩa get() set() 

            //Chấn ĐỘng - New và SET gọi cùng lúc
            var dung = new Student()
            {
                Id = "SE4",
                Name = "Dũng",
                Yob = 2009,
                Gpa = 8.3
                //Cú pháp này được gọi là Object Initialization
                //Tạo object đồng thời gán các Backing Field qua Property
            };
            Console.WriteLine("Dũng Info : " + dung);
            
        }
    }
}
