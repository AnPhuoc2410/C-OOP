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
        }
    }
}
