using StudentTester.Entities;

namespace StudentTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateStudentObject();
        }

        static void CreateStudentObject()
        {

            Student Jett = new Student("Se", "Jett", 2004, 8.9);
            //Gọi vật liệu xong đổ nguyên liệu vào, để đúc 1 object
            //giống như đổ mực lên phôi dể clone thành 1 CCCD 
            Student Reyna = new("SE2", "Reyna", 2004, 8.8);
            //new kiểu mới, k cần đi kèm DATA TYPE vì bên khái báo đã chỉ ra rồi
            //var student2 = new ("SE3", "Neon", 2004, 8.7);
            //khai báo kiểu này 2 bên đề k rõ ràng về Data Type ERROR
            var Neon = new Student("SE3", "Neon", 2004, 8.7);

            //Student Astra = new(8.6, 2004, "SE4", "Astra");
            //Khi gọi tham số hàm, phải gọi đúng thứ tự biến đc xác định ở tên hàm. Contructor cần fill info của object, các phếu nhận vật liệu
            Student Yoru = new(gpa: 8.6, yob: 2003, name: "Yoru", id: "SE5");
            //Kĩ thuật gọi contructor ko theo thứ tự của biến, miễn là chỉ ra được biến này có tên là gì- giá trị thế nào "parameter:"
            //Kĩ thuật này giúp ta linh hoạt cách gọi hàm
            //kĩ thuật này gọi là : NAMED-ARGUMENT
            //GỌI HÀM ĐI KÈM TÊN THAM SỐ

            //Flex Info
            //Con người có xu hướng đặt tên gọi cho mọi thứ
            Jett.FlexProfile();
            Neon.FlexProfile();
            Yoru.FlexProfile();
            Reyna.FlexProfile();

            Console.WriteLine("Jett name: " + Jett.GetAge());
            Console.WriteLine($"Neon name: {Neon.GetAge()}");
            Console.WriteLine($"Yoru name: {Yoru.GetAge()}");
            Console.WriteLine($"Reyna name: {0}",Reyna.GetAge());

            //CODING CONVENTION - QUY TẮC ĐẶT TÊN TRONG C#
            //I. TÊN CỦA SOLUTION


            //II. TÊN CỦA PROJECT


            //III.TÊN CỦA NAMESPACE

            //IV.TÊN CỦA CLASS/ INTERFACE/ DELEGATES
            //1.TÊN CLASS
            //-DANH TỪ, CHỮ HOA TỪNG ĐẦU TỪ - Pascal Case Notation -> Bắt chước theo ngôn ngữ lập trình Pascal
            //* Ví dụ: Student, Lecturer, Dog,...File, Console, ArrayList

            //V. TÊN BIẾN (BIẾN CỤC BỘ TRONG HÀM, BIẾN NGOÀI HÀM FIELDS)
            //1. "Biến toàn cục" FIELD/ATTRIBUTE
            //-Danh từ, cú pháp con Lạc Đà, chữ hoa từng đầu từ, từ đầu tiên viết chữ thường kèm "_" đứng đầu
            //vd: _id, _name, _salary,..

            //1.5. PROPERTY (Biến lai với hàm - làm Get Set)
            //Property là kĩ thuật viết hàm get set gọn gàng qua style xài biến, ta độ thêm 1 biến và bao cái _FIELD qua 2 hàm Get Set xài tự nhiên qua biến lai PROPERTY
            //Tên biến lau PROPERTY phải là danh từ, chữ hoa từng đầu từ (Pascal Case), đã có động từ get set bị che bên trong property
            //Có nhiều kĩ thuật sài property, từ V3 trở đi

            //2. "Biến cục bộ" - LOCAL VARIABLE - Biến nằm trong hàm, hoặc tham số hàm parameter
            //-Danh từ, cú pháp con lạc đà, từ đầu tiên chữ thường, các từ còn lại chữ Hoa từng đầu từ
            // Vd: salary, sum, count, yob

            //VI.TÊN METHOD
            //- Verb + Object, cú pháp pascal, Pascal Case Notation
            // Chữ hoa từng đầu từ, Từ Đầu Tiên Là Động Từ
            //* Vd: GetName(), ToSring(), Main, Convert(), SetName()


            //Cập nhật thông tin SV
            Yoru.SetGpa(8.5); //EXPECTED: 8.5

            Console.WriteLine("Jett gpa: " + Jett.GetGpa());
            Console.WriteLine($"Neon gpa: {Neon.GetGpa()}");
            Console.WriteLine($"Yoru gpa: {Yoru.GetGpa()}");
            Console.WriteLine($"Reyna gpa: {0}", Reyna.GetGpa());

            Student s = Yoru;//s trỏ tới vùng ram Yoru

            s.SetGpa(67.89);
            Console.WriteLine("Yoru FlexProfile after s: ");
            Yoru.FlexProfile();

            //Question:
            s = Jett;
            //s và Jett cùng trỏ tới vùng ram "Jett"
            s.FlexProfile();
            Yoru = Jett;//Lúc này s , Jett, Yoru cũng trỏ tới vùng ram "Jett"

            Console.WriteLine("Giả trị Yoru sẽ k còn do Garbage Colletor");
            Yoru.FlexProfile();//Giá trị Yoru là của Jett

            //Lúc này để giữ lại giá trị Yoru ko bị Garbage Colletor xóa lúc Runtime
            Student x = Yoru;//giữ giá trị Yoru bằng x
        }
    }
}
